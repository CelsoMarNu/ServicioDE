using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ServicioDE.Objetos.ProcesarLote
{
    [XmlRoot(ElementName = "gOpeDE", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GOpeDE
    {
        [XmlElement(ElementName = "iTipEmi", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ITipEmi { get; set; }
    }

    [XmlRoot(ElementName = "gTimb", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GTimb
    {
        [XmlElement(ElementName = "iTiDE", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ITiDE { get; set; }

        [XmlElement(ElementName = "dDesTiDE", Namespace = "http://ws.efactura.isaltda.py/")]
        public string dDesTiDE { get; set; }

        [XmlElement(ElementName = "dNumTim", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNumTim { get; set; }

        [XmlElement(ElementName = "dEst", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DEst { get; set; }

        [XmlElement(ElementName = "dPunExp", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DPunExp { get; set; }

        [XmlElement(ElementName = "dNumDoc", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNumDoc { get; set; }
        [XmlElement(ElementName = "dFeIniT", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DFeIniT { get; set; }
    }

    [XmlRoot(ElementName = "gOpeCom", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GOpeCom
    {
        [XmlElement(ElementName = "iTipTra", Namespace = "http://ws.efactura.isaltda.py/")]
        public int ITipTra { get; set; }

        [XmlElement(ElementName = "iTImp", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ITImp { get; set; }

        [XmlElement(ElementName = "cMoneOpe", Namespace = "http://ws.efactura.isaltda.py/")]
        public string CMoneOpe { get; set; }

        [XmlElement(ElementName = "dDesMoneOp", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDesMoneOp { get; set; }

        [XmlElement(ElementName = "dCondTiCam", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DCondTiCam { get; set; }
        [XmlElement(ElementName = "dTiCam", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTiCam { get; set; }
    }

    [XmlRoot(ElementName = "gEmis", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GEmis
    {
        [XmlElement(ElementName = "dRucEm", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DRucEm { get; set; }

        [XmlElement(ElementName = "dDVEmi", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDVEmi { get; set; }

        [XmlElement(ElementName = "iTipCont", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ITipCont { get; set; }
        [XmlElement(ElementName = "dNomFanEmi", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNomFanEmi { get; set; }
        [XmlElement(ElementName = "dDirEmi", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDirEmi { get; set; }
        [XmlElement(ElementName = "dNumCas", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNumCas { get; set; }
        [XmlElement(ElementName = "cDepEmi", Namespace = "http://ws.efactura.isaltda.py/")]
        public string CDepEmi { get; set; }
        [XmlElement(ElementName = "dDesDepEmi", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDesDepEmi { get; set; }
        [XmlElement(ElementName = "cDisEmi", Namespace = "http://ws.efactura.isaltda.py/")]
        public string CDisEmi { get; set; }
        [XmlElement(ElementName = "dDesDisEmi", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDesDisEmi { get; set; }
        [XmlElement(ElementName = "cCiuEmi", Namespace = "http://ws.efactura.isaltda.py/")]
        public string CCiuEmi { get; set; }
        [XmlElement(ElementName = "dDesCiuEmi", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDesCiuEmi { get; set; }
        [XmlElement(ElementName = "dTelEmi", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTelEmi { get; set; }
        [XmlElement(ElementName = "dEmail", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DEmail { get; set; }
        [XmlElement(ElementName = "gActEco", Namespace = "http://ws.efactura.isaltda.py/")]
        public string GActEco { get; set; }




    }

    [XmlRoot(ElementName = "gDatRec", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GDatRec
    {
        [XmlElement(ElementName = "iNatRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public string INatRec { get; set; }

        [XmlElement(ElementName = "iTiOpe", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ITiOpe { get; set; }

        [XmlElement(ElementName = "iTipIDRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ITipIDRec { get; set; }

        [XmlElement(ElementName = "dNumIDRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNumIDRec { get; set; }

        [XmlElement(ElementName = "dNomRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNomRec { get; set; }

        [XmlElement(ElementName = "dDirRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDirRec { get; set; }

        [XmlElement(ElementName = "dNumCasRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNumCasRec { get; set; }

        [XmlElement(ElementName = "cPaisRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public string CPaisRec { get; set; }

        [XmlElement(ElementName = "dDesPaisRe", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDesPaisRe { get; set; }

        [XmlElement(ElementName = "dRucRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DRucRec { get; set; }

        [XmlElement(ElementName = "dDVRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDVRec { get; set; }
        [XmlElement(ElementName = "iTiContRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ITiContRec { get; set; }
        [XmlElement(ElementName = "dEmailRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DEmailRec { get; set; }
    }

    [XmlRoot(ElementName = "gDatGralOpe", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GDatGralOpe
    {
        [XmlElement(ElementName = "dFeEmiDE", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DFeEmiDE { get; set; }

        [XmlElement(ElementName = "gOpeCom", Namespace = "http://ws.efactura.isaltda.py/")]
        public GOpeCom GOpeCom { get; set; }

        [XmlElement(ElementName = "gEmis", Namespace = "http://ws.efactura.isaltda.py/")]
        public GEmis GEmis { get; set; }

        [XmlElement(ElementName = "gDatRec", Namespace = "http://ws.efactura.isaltda.py/")]
        public GDatRec GDatRec { get; set; }
    }

    [XmlRoot(ElementName = "gCamFE", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GCamFE
    {
        [XmlElement(ElementName = "iIndPres", Namespace = "http://ws.efactura.isaltda.py/")]
        public string IIndPres { get; set; }
    }

    [XmlRoot(ElementName = "gValorRestaItem", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GValorRestaItem
    {
        [XmlElement(ElementName = "dDescItem", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDescItem { get; set; }
        [XmlElement(ElementName = "dPorcDesIt", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DPorcDesIt { get; set; }
        [XmlElement(ElementName = "dDescGloItem", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDescGloItem { get; set; }
        [XmlElement(ElementName = "dAntPreUnitIt", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DAntPreUniIt { get; set; }
        [XmlElement(ElementName = "dAntGloPreUniIt", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DAntGloPreUniIt { get; set; }

        [XmlElement(ElementName = "dTotOpeItem", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTotOpeItem { get; set; }
    }

    [XmlRoot(ElementName = "gValorItem", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GValorItem
    {
        [XmlElement(ElementName = "dPUniProSer", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DPUniProSer { get; set; }

        [XmlElement(ElementName = "dTotBruOpeItem", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTotBruOpeItem { get; set; }

        [XmlElement(ElementName = "gValorRestaItem", Namespace = "http://ws.efactura.isaltda.py/")]
        public GValorRestaItem GValorRestaItem { get; set; }
    }

    [XmlRoot(ElementName = "gCamIVA", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GCamIVA
    {
        [XmlElement(ElementName = "iAfecIVA", Namespace = "http://ws.efactura.isaltda.py/")]
        public string IAfecIVA { get; set; }
        [XmlElement(ElementName = "dDesAfecIVA", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDesAfecIVA { get; set; }
        [XmlElement(ElementName = "dPropIVA", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DPropIVA { get; set; }

        [XmlElement(ElementName = "dTasaIVA", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTasaIVA { get; set; }
        [XmlElement(ElementName = "dBasGravIVA", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DBasGravIVA { get; set; }
        [XmlElement(ElementName = "dLiqIVAItem", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DLiqIVAItem { get; set; }
    }

    [XmlRoot(ElementName = "gCamItem", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GCamItem
    {
        [XmlElement(ElementName = "dCodInt", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DCodInt { get; set; }

        [XmlElement(ElementName = "dDesProSer", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDesProSer { get; set; }

        [XmlElement(ElementName = "dCantProSer", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DCantProSer { get; set; }

        [XmlElement(ElementName = "gValorItem", Namespace = "http://ws.efactura.isaltda.py/")]
        public GValorItem GValorItem { get; set; }

        [XmlElement(ElementName = "gCamIVA", Namespace = "http://ws.efactura.isaltda.py/")]
        public GCamIVA GCamIVA { get; set; }
    }

    [XmlRoot(ElementName = "gPagTarCD", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GPagTarCD
    {
        [XmlElement(ElementName = "iDenTarj", Namespace = "http://ws.efactura.isaltda.py/")]
        public int IDenTarj { get; set; }

        [XmlElement(ElementName = "dDesDenTarj", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDesDenTarj { get; set; }

        [XmlElement(ElementName = "dRSProTar", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DRSProTar { get; set; }

        [XmlElement(ElementName = "iForProPa", Namespace = "http://ws.efactura.isaltda.py/")]
        public int IForProPa { get; set; }
    }
    [XmlRoot(ElementName = "gPagCred", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GPagCred
    {
        [XmlElement(ElementName = "iCondCred", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ICondCred { get; set; }

        [XmlElement(ElementName = "dDConCred", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDConCred { get; set; }

        [XmlElement(ElementName = "dPlazoCred", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DPlazoCred { get; set; }

    }
    [XmlRoot(ElementName = "gPaConEIni", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GPaConEIni
    {
        [XmlElement(ElementName = "iTiPago", Namespace = "http://ws.efactura.isaltda.py/")]
        public int ITiPago { get; set; }

        [XmlElement(ElementName = "dMonTiPag", Namespace = "http://ws.efactura.isaltda.py/")]
        public int DMonTiPag { get; set; }

        [XmlElement(ElementName = "cMoneTiPag", Namespace = "http://ws.efactura.isaltda.py/")]
        public string CMoneTiPag { get; set; }

        [XmlElement(ElementName = "gPagTarCD", Namespace = "http://ws.efactura.isaltda.py/")]
        public GPagTarCD GPagTarCD { get; set; }
    }

    [XmlRoot(ElementName = "gCamCond", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GCamCond
    {
        [XmlElement(ElementName = "iCondOpe", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ICondOpe { get; set; }
        [XmlElement(ElementName = "dDComOpe", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDComOpe { get; set; }

        [XmlElement(ElementName = "gPagCred", Namespace = "http://ws.efactura.isaltda.py/")]
        public GPagCred GPagCred { get; set; }

    }

    [XmlRoot(ElementName = "gDtipDE", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GDtipDE
    {
        [XmlElement(ElementName = "gCamFE", Namespace = "http://ws.efactura.isaltda.py/")]
        public GCamFE GCamFE { get; set; }

        [XmlElement(ElementName = "gCamItem", Namespace = "http://ws.efactura.isaltda.py/")]
        public List<GCamItem> GCamItem { get; set; }

        [XmlElement(ElementName = "gCamCond", Namespace = "http://ws.efactura.isaltda.py/")]
        public GCamCond GCamCond { get; set; }
    }

    [XmlRoot(ElementName = "gTotSub", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GTotSub
    {
        [XmlElement(ElementName = "dSubExe", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DSubExe { get; set; }
        [XmlElement(ElementName = "dSubExo", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DSubExo { get; set; }
        [XmlElement(ElementName = "dSub5", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DSub5 { get; set; }
        [XmlElement(ElementName = "dSub10", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DSub10 { get; set; }
        [XmlElement(ElementName = "dTotOpe", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTotOpe { get; set; }
        [XmlElement(ElementName = "dTotDesc", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTotDesc { get; set; }
        [XmlElement(ElementName = "dTotDescGlotem", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTotDescGlotem { get; set; }
        [XmlElement(ElementName = "dTotAntItem", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTotAntItem { get; set; }
        [XmlElement(ElementName = "dTotAnt", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTotAnt { get; set; }        
        [XmlElement(ElementName = "dPorcDescTotal", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DPorcDescTotal { get; set; }
        [XmlElement(ElementName = "dDescTotal", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDescTotal { get; set; }
        [XmlElement(ElementName = "dAnticipo", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DAnticipo { get; set; }
        [XmlElement(ElementName = "dRedon", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DRedon { get; set; }
        
        [XmlElement(ElementName = "dTotGralOpe", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTotGralOpe { get; set; }
        [XmlElement(ElementName = "dIVA5", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DIVA5 { get; set; }
        [XmlElement(ElementName = "dIVA10", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DIVA10 { get; set; }
        [XmlElement(ElementName = "dLiqTotIVA5", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DLiqTotIVA5 { get; set; }
        [XmlElement(ElementName = "dLiqTotIVA10", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DLiqTotIVA10 { get; set; }
        [XmlElement(ElementName = "dTotIVA", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTotIVA { get; set; }
        [XmlElement(ElementName = "dBaseGrav5", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DBaseGrav5 { get; set; }
        
        [XmlElement(ElementName = "dBaseGrav10", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DBaseGrav10 { get; set; }
        [XmlElement(ElementName = "dTBasGraIVA", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTBasGraIVA { get; set; }
        [XmlElement(ElementName = "dTotalGS", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DTotalGS { get; set; }


    }

    [XmlRoot(ElementName = "DE")]
    public class DE
    {
        [XmlElement(ElementName = "dDVId", Namespace = "http://ws.efactura.isaltda.py/")]
        public string dDVId { get; set; }
        [XmlElement(ElementName = "dFecFirma", Namespace = "http://ws.efactura.isaltda.py/")]
        public string dFecFirma { get; set; }
        [XmlElement(ElementName = "dSisFac", Namespace = "http://ws.efactura.isaltda.py/")]
        public string dSisFac { get; set; }
        [XmlElement(ElementName = "gOpeDE", Namespace = "http://ws.efactura.isaltda.py/")]
        public GOpeDE GOpeDE { get; set; }

        [XmlElement(ElementName = "gTimb", Namespace = "http://ws.efactura.isaltda.py/")]
        public GTimb GTimb { get; set; }

        [XmlElement(ElementName = "gDatGralOpe", Namespace = "http://ws.efactura.isaltda.py/")]
        public GDatGralOpe GDatGralOpe { get; set; }

        [XmlElement(ElementName = "gDtipDE", Namespace = "http://ws.efactura.isaltda.py/")]
        public GDtipDE GDtipDE { get; set; }

        [XmlElement(ElementName = "gTotSub", Namespace = "http://ws.efactura.isaltda.py/")]
        public GTotSub GTotSub { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "gCamDEAsoc", Namespace = "http://ws.efactura.isaltda.py/")]
        public List<GCamDEAsoc> GCamDEAsoc { get; set; }

    }

    [XmlRoot(ElementName = "rDE", Namespace = "http://ws.efactura.isaltda.py/")]
    public class RDE
    {
        [XmlElement(ElementName = "dVerFor", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DVerFor { get; set; }

        [XmlElement(ElementName = "DE", Namespace = "http://ws.efactura.isaltda.py/")]
        public DE DE { get; set; }
    }

    [XmlRoot(ElementName = "parametrosProcesamiento", Namespace = "http://ws.efactura.isaltda.py/")]
    public class ParametrosProcesamiento
    {
        [XmlElement(ElementName = "retornarKuDE", Namespace = "http://ws.efactura.isaltda.py/")]
        public bool RetornarKuDE { get; set; }

        [XmlElement(ElementName = "retornarXmlFirmado", Namespace = "http://ws.efactura.isaltda.py/")]
        public bool RetornarXmlFirmado { get; set; }

        [XmlElement(ElementName = "templateKuDE", Namespace = "http://ws.efactura.isaltda.py/")]
        public string TemplateKuDE { get; set; }

        [XmlElement(ElementName = "forzarReingreso", Namespace = "http://ws.efactura.isaltda.py/")]
        public bool ForzarReingreso { get; set; }

        [XmlElement(ElementName = "notificarMail", Namespace = "http://ws.efactura.isaltda.py/")]
        public bool NotificarMail { get; set; }

        [XmlElement(ElementName = "validarCalculos", Namespace = "http://ws.efactura.isaltda.py/")]
        public bool ValidarCalculos { get; set; }
    }

    [XmlRoot(ElementName = "procesarDocumento", Namespace = "http://ws.efactura.isaltda.py/")]
    public class ProcesarDocumento
    {
        [XmlElement(ElementName = "rDE", Namespace = "http://ws.efactura.isaltda.py/")]
        public RDE RDE { get; set; }

        [XmlElement(ElementName = "parametrosProcesamiento", Namespace = "http://ws.efactura.isaltda.py/")]
        public ParametrosProcesamiento ParametrosProcesamiento { get; set; }
    }

    [XmlRoot(ElementName = "procesarLotePorFacturaRequest", Namespace = "http://ws.efactura.isaltda.py/")]
    public class ProcesarLotePorFacturaRequest
    {
        [XmlElement(ElementName = "procesarDocumento", Namespace = "http://ws.efactura.isaltda.py/")]
        public ProcesarDocumento ProcesarDocumento { get; set; }

        [XmlAttribute(AttributeName = "xmlns", Namespace = "http://ws.efactura.isaltda.py/")]
        public string Xmlns { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Body")]
    public class Body
    {
        [XmlElement(ElementName = "procesarLotePorFacturaRequest", Namespace = "http://ws.efactura.isaltda.py/")]
        public ProcesarLotePorFacturaRequest ProcesarLotePorFacturaRequest { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public object Header { get; set; }

        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }

        [XmlAttribute(AttributeName = "soapenv", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public string Soapenv { get; set; }

        [XmlAttribute(AttributeName = "ws", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public string ws { get; set; }
    }
    [XmlRoot(ElementName = "GCamDEAsoc", Namespace = "http://ws.efactura.isaltda.py/")]
    public class GCamDEAsoc
    {
        [XmlElement(ElementName = "iTipDocAso", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ITipDocAso { get; set; }        
        [XmlElement(ElementName = "dDesTipDocAso", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDesTipDocAso { get; set; }
        [XmlElement(ElementName = "dCdCDERef", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DCdCDERef { get; set; }
        [XmlElement(ElementName = "dNTimDI", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNTimDI { get; set; }
        [XmlElement(ElementName = "dEstDocAso", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DEstDocAso { get; set; }
        [XmlElement(ElementName = "dPExpDocAso", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DPExpDocAso { get; set; }
        [XmlElement(ElementName = "dNumDocAso", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNumDocAso { get; set; }
        [XmlElement(ElementName = "iTipoDocAso", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ITipoDocAso { get; set; }
        [XmlElement(ElementName = "dDTipoDocAso", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDTipoDocAso { get; set; }
        [XmlElement(ElementName = "dFecEmiDI", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DFecEmiDI { get; set; }
        [XmlElement(ElementName = "dNumComRet", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNumComRet { get; set; }
        [XmlElement(ElementName = "dNumResCF", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNumResCF { get; set; }
        [XmlElement(ElementName = "iTipCons", Namespace = "http://ws.efactura.isaltda.py/")]
        public string ITipCons { get; set; }
        [XmlElement(ElementName = "dDesTipCons", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DDesTipCons { get; set; }
        [XmlElement(ElementName = "dNumCons", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNumCons { get; set; }
        [XmlElement(ElementName = "dNumControl", Namespace = "http://ws.efactura.isaltda.py/")]
        public string DNumControl { get; set; }
    }
}