using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioDE.DTO
{
    public class DocumentoEntity
    {
        public string Tipo { get; set; }
        public int NumTim { get; set; }
        public string NumDoc { get; set; }
        public string ID { get; set; }
        public string CDC { get; set; }
        public DateTime? FechaEmision { get; set; }
        public string KuDE { get; set; }
        public string XmlFirmado { get; set; }
        public string DocumentoError { get; set; }
    }

    public class ParametroEntity
    {
        public string Ws { get; set; }
        public string SoapEnv { get; set; }
        public string UrlProLotPFac { get; set; }
    }

}
