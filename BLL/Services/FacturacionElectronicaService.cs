using Microsoft.EntityFrameworkCore;
using ServicioDE.DAL;
using ServicioDE.DTO;
using ServicioDE.Objetos;
using ServicioDE.Objetos.ProcesarLote;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ServicioDE.BLL.Services
{
    public class FacturacionElectronicaService
    {
        public ServicioDEContext _context;
        public async Task<bool> procesarFactura(DataTable cabecera, DataTable detalle, DataTable parametros)
        {
            var r = await procesarLotePorFactura(cabecera, detalle, parametros);
           
            if (r.Body.procesarLoteFacturasReponse.Return.Ok == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<procesarLotePorFacturaResponseEnvelope> procesarLotePorFactura(DataTable dtcabecera, DataTable dtdetalle, DataTable dtparametros)
        {           
            var Listaparametros = new List<ParametroEntity>();
            Listaparametros = _context.TraerParametros(dtparametros);
            var parametros = new ParametroEntity();
            parametros = Listaparametros.First();

            XNamespace soapenv = parametros.SoapEnv;
            XNamespace ws = parametros.Ws;
            string soapResult;
            procesarLotePorFacturaResponseEnvelope result = new procesarLotePorFacturaResponseEnvelope();
            try
            {
                var cabeceras = _context.TraerCabecera(dtcabecera);
                if (!cabeceras.Any())
                {
                    return new procesarLotePorFacturaResponseEnvelope()
                    {
                        Body = new procesarLotePorFacturaResponseBody()
                        {
                            procesarLoteFacturasReponse = new procesarLotePorFacturaResponse
                            {
                                Return = new Return()
                                {
                                    MensajeError = "no se encontraron cabecera",
                                    Ok = "false"
                                }
                            }
                        }
                    };
                }
                var cabecera = new DE();
                cabecera = crearDocumento(cabeceras.First());
                var rDE = new RDE()
                {
                    DE = cabecera,
                    DVerFor = "150",
                };
                var procesarDocumento = new ProcesarDocumento()
                {
                    RDE = rDE,
                    ParametrosProcesamiento = new ParametrosProcesamiento()
                    {
                        RetornarKuDE = true,
                        RetornarXmlFirmado = true,
                        NotificarMail = true,
                    }
                };
                var request = new ProcesarLotePorFacturaRequest()
                {
                    ProcesarDocumento = procesarDocumento
                };
                var body = new Body()
                {
                    ProcesarLotePorFacturaRequest = request
                };
                var envelope = new Envelope()
                {
                    Body = body,
                    Header = "",
                    Soapenv = parametros.SoapEnv,
                    ws = parametros.Ws
                };
                var serializer = new XmlSerializer(typeof(Envelope));
                var setting = new XmlWriterSettings
                {
                    Encoding = Encoding.UTF8,
                    Indent = true,
                    OmitXmlDeclaration = true,
                };
                var builder = new StringBuilder();
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

                ns.Add("", "");
                using (var write = XmlWriter.Create(builder, setting))
                {
                    serializer.Serialize(write, envelope, ns);
                }

                XmlDocument soapFacturacionDocument = new XmlDocument();
                soapFacturacionDocument.LoadXml(builder.ToString());
                try
                {
                    //armar  la peticion
                    HttpWebRequest webRequest = CreateWebRequest("", "");
                    InsertSoapEnvelopeIntoWebRequest(soapFacturacionDocument, webRequest);
                    IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

                    try
                    {
                        asyncResult.AsyncWaitHandle.WaitOne();
                        using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
                        {
                            using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                            {
                                soapResult = rd.ReadToEnd();
                                XmlSerializer serializerResponse = new XmlSerializer(typeof(procesarLotePorFacturaResponseEnvelope));
                                using (TextReader reader = new StringReader(soapResult))
                                {
                                    result = (procesarLotePorFacturaResponseEnvelope)serializerResponse.Deserialize(reader);
                                }
                            }
                        }
                    }
                    catch (WebException wex)
                    {
                        var pageContent = new StreamReader(wex.Response.GetResponseStream()).ReadToEnd;
                        result.Body.procesarLoteFacturasReponse.Return.Ok = "false";
                        result.Body.procesarLoteFacturasReponse.Return.MensajeError = pageContent.ToString();
                        return result;
                    }
                }
                catch (Exception ex)
                {
                    result.Body.procesarLoteFacturasReponse.Return.Ok = "false";
                    result.Body.procesarLoteFacturasReponse.Return.MensajeError = ex.Message;
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.Body.procesarLoteFacturasReponse.Return.Ok = "false";
                result.Body.procesarLoteFacturasReponse.Return.MensajeError = ex.Message;
                return result;
            }
            return result;
        }

        public void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            using (Stream stream = webRequest.GetRequestStream())
            {
                soapEnvelopeXml.Save(stream);
            }
        }
        public HttpWebRequest CreateWebRequest(string url, string action)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Headers.Add("SOAPAction", action);
            webRequest.Headers.Add("Accept-Encoding", "gzip,deflate");
            webRequest.ContentType = "text/xml;charset=\"UTF-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";

            return webRequest;
        }
        public DE crearDocumento(CabeceraEntity cabeceraEntity)
        {
            var cabecera = new DE();
            try
            {
                var tipoDocumento = Convert.ToInt32(cabeceraEntity.ITiDE);
                cabecera.dFecFirma = cabeceraEntity.DFeEmiDE.ToString().Replace(" ", "T");
                cabecera.dSisFac = "1";
                cabecera.dDVId = cabeceraEntity.DDVEmi.ToString();
                cabecera.Id = cabeceraEntity.Id.ToString();

                cabecera.GOpeDE = new GOpeDE()
                {
                    ITipEmi = cabeceraEntity.ITipEmi.ToString(),
                };
                cabecera.GTimb = new GTimb()
                {
                    ITiDE = tipoDocumento.ToString(),
                    DNumTim = cabeceraEntity.DNumTim.ToString(),
                    DEst = cabeceraEntity.DEst.ToString(),
                    DPunExp = cabeceraEntity.DPuntExp.ToString(),
                    DFeIniT = cabeceraEntity.DFeIniT.ToString("yyyy-MM-dd"),
                };
                var moneda = cabeceraEntity.CMoneOpe.ToString();
                cabecera.GDatGralOpe = new GDatGralOpe()
                {
                    DFeEmiDE = cabeceraEntity.DFeEmiDE.ToString().Replace(" ", "T"),
                    GOpeCom = new GOpeCom()
                    {
                        ITImp = cabeceraEntity.ITImp.ToString(),
                        CMoneOpe = moneda,
                        DCondTiCam = moneda == "PYG" ? null : cabeceraEntity.DCondTiCam.ToString(),
                        DTiCam = moneda == "PYG" ? null : cabeceraEntity.DTiCam.ToString(),
                    },
                    GEmis = new GEmis()
                    {
                        DRucEm = cabeceraEntity.DRucEm.ToString(),
                        DDVEmi = cabeceraEntity.DDVEmi.ToString(),
                    },
                    GDatRec = new GDatRec()
                    {
                        INatRec = cabeceraEntity.INatRec.ToString(),
                        ITiOpe = cabeceraEntity.ITiOpe.ToString(),
                        DRucRec = cabeceraEntity.INatRec.ToString() == "1" ? cabeceraEntity.DRucRec.ToString() : null,
                        DDVRec = cabeceraEntity.INatRec.ToString() == "1" ? cabeceraEntity.DDVRec.ToString() : null,
                        ITiContRec = cabeceraEntity.INatRec.ToString() == "1" ? cabeceraEntity.ITiContRec.ToString() : null,
                        DNomRec = cabeceraEntity.DNomRec.ToString(),
                        DDirRec = cabeceraEntity.DDirRec.ToString(),
                        CPaisRec = cabeceraEntity.CPaisRec.ToString(),
                        DNumCasRec = cabeceraEntity.DNumCasRec.ToString(),
                        DEmailRec = cabeceraEntity.DEmailRec.ToString(),
                        ITipIDRec = string.IsNullOrEmpty(cabeceraEntity.ITipIDRec.ToString()) ? null : cabeceraEntity.ITipIDRec.ToString(),
                        DNumIDRec = cabeceraEntity.INatRec.ToString() == "1" ? cabeceraEntity.DRucRec.ToString() : null,
                    }
                };
                var NroDocumento = cabeceraEntity.DEst + cabeceraEntity.DPuntExp + cabeceraEntity.DNumDoc;

                var detalle = new List<DetalleEntity>();
                var listagCamItem = new List<GCamItem>();
                var dIVA5 = 0.0;
                var dIVA10 = 0.0;
                var dBaseGrav5 = 0.0;
                var dBaseGrav10 = 0.0;
                var listaItem = new List<GCamItem>();
                var totalOperacion = Convert.ToInt32(cabeceraEntity.DTotOpe);

                foreach (DetalleEntity Detalle in detalle)
                {
                    var cantidad = Convert.ToDouble(Detalle.DCantProSer);
                    var precioPorUnidad = Convert.ToDouble(Detalle.DPUniProSer);
                    var tasaIva = Convert.ToInt32(Detalle.DTasaIVA);
                    var proporcionGravada = 100;
                    var afecIva = tasaIva == 0 ? "3" : "1";
                    var baseGravado = afecIva == "3" ? 0 : (tasaIva == 10 ? (((cantidad * precioPorUnidad) * (proporcionGravada / 100)) / 1.1) : ((cantidad * precioPorUnidad) * (proporcionGravada / 100)) / 1.05);
                    var liqIvaItem = afecIva == "3" ? 0 : baseGravado * Convert.ToDouble(Convert.ToDouble(tasaIva) / 100);

                    var gCamItem = new GCamItem()
                    {
                        DCodInt = Detalle.DCodInt.ToString(),
                        DDesProSer = Detalle.DDesProSer.ToString(),
                        DCantProSer = cantidad.ToString(),
                        GValorItem = new GValorItem()
                        {
                            DPUniProSer = precioPorUnidad.ToString(),
                            DTotBruOpeItem = (cantidad * precioPorUnidad).ToString("#.##"),
                            GValorRestaItem = new GValorRestaItem()
                            {
                                DTotOpeItem = (cantidad * precioPorUnidad).ToString("#.##"),
                                DAntGloPreUniIt = "0",
                                DAntPreUniIt = "0",
                                DDescGloItem = "0.00000000",
                                DDescItem = "0",
                                DPorcDesIt = "0"
                            }
                        },
                        GCamIVA = new GCamIVA()
                        {
                            DTasaIVA = tasaIva.ToString(),
                            IAfecIVA = afecIva,
                            DBasGravIVA = baseGravado.ToString("#.##"),
                            DLiqIVAItem = liqIvaItem.ToString("#.##"),
                            DPropIVA = afecIva == "3" ? "0" : proporcionGravada.ToString()
                        }
                    };
                    if (tasaIva == 10)
                    {
                        dIVA10 += liqIvaItem;
                        dBaseGrav10 += baseGravado;
                    }
                    else
                    {
                        dIVA5 += liqIvaItem;
                        dBaseGrav5 += baseGravado;
                    }
                    listaItem.Add(gCamItem);

                }
                var gDtipDE = new GDtipDE();
                var listaGCamDEAsoc = new List<GCamDEAsoc>();

                switch (tipoDocumento)
                {
                    case 1://Factura Electronica
                        gDtipDE.GCamFE = new GCamFE()
                        {
                            IIndPres = cabeceraEntity.ICondOpe.ToString(),
                        };
                        gDtipDE.GCamCond = new GCamCond()
                        {
                            ICondOpe = cabeceraEntity.ICondOpe.ToString(),
                            GPagCred = cabeceraEntity.ICondOpe.ToString() == "1" ? null : new GPagCred()
                            {
                                ICondCred = cabeceraEntity.ICondCred.ToString(),
                                DDConCred = cabeceraEntity.DDCondCred.ToString(),
                                DPlazoCred = cabeceraEntity.DPlazoCre.ToString()
                            }
                        };
                        cabecera.GTotSub = new GTotSub()
                        {
                            DSubExe = cabeceraEntity.DSubExe.ToString(),
                            DSubExo = cabeceraEntity.DSubExo.ToString(),
                            DSub5 = cabeceraEntity.DSub5.ToString(),
                            DSub10 = cabeceraEntity.DSub10.ToString(),
                            DTotOpe = totalOperacion.ToString(),
                            DTotDesc = cabeceraEntity.DTotDesc.ToString(),
                            DTotDescGlotem = cabeceraEntity.DTotDescGlotem.ToString(),
                            DAnticipo = "0",
                            DTotalGS = cabeceraEntity.CMoneOpe.ToString() != "PYG" ? (totalOperacion * Convert.ToInt32(cabeceraEntity.DTiCam)).ToString("#.##") : null,
                            DBaseGrav10 = dBaseGrav10.ToString("#.##"),
                            DBaseGrav5 = dBaseGrav5.ToString("#.##"),
                            DDescTotal = "0",
                            DIVA10 = dIVA10.ToString("#.##"),
                            DIVA5 = dIVA5.ToString("#.##"),
                            DTotGralOpe = totalOperacion.ToString(),
                            DLiqTotIVA10 = "0",
                            DLiqTotIVA5 = "0",
                            DPorcDescTotal= "0",
                            DTBasGraIVA = (dBaseGrav10 + dBaseGrav5).ToString("#.##"),
                            DTotAntItem = "0",
                            DTotIVA = (dIVA10 + dIVA5).ToString("#.##"),
                            DTotAnt = "0",
                            DRedon = "0"
                        };
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }
                cabecera.GCamDEAsoc = listaGCamDEAsoc;
                gDtipDE.GCamItem = listaItem;
                cabecera.GDtipDE = gDtipDE;
            }
            catch (Exception)
            {

                throw;
            }
            return cabecera;
        }
        DbSet<ParametroEntity> Parametros { get; set; }
        DbSet<CabeceraEntity> Cabecera { get; set; }
        DbSet<DetalleEntity> Detalle { get; set; }
        private string ConectionString;

        public List<DetalleEntity> TraerDetalle(DataTable dtDetalle)
        {
            var r = new List<DetalleEntity>();
            r = DataTableToList<DetalleEntity>(dtDetalle).ToList();
            return r;
        }

        public List<CabeceraEntity> TraerCabecera(DataTable dtCabecera)
        {
            var r = new List<CabeceraEntity>();
            r = DataTableToList<CabeceraEntity>(dtCabecera).ToList();
            return r;
        }

        public List<ParametroEntity> TraerParametros(DataTable dtParametros)
        {
            var r = new List<ParametroEntity>();
            r = DataTableToList<ParametroEntity>(dtParametros).ToList();
            return r;
        }

        public List<T> DataTableToList<T>(this DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}
