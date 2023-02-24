using System.Xml.Serialization;

namespace ServicioDE.Objetos.ProcesarLote
{
    [XmlRoot(ElementName = "documentoElectronicoGenerado", Namespace = "")]
    public class DocumentoElectronicoGenerado
    {
        [XmlElement(ElementName = "id", Namespace = "http://ws.efactura.isaltda.py/")]
        public string Id { get; set; }
        [XmlElement(ElementName = "KuDE", Namespace = "http://ws.efactura.isaltda.py/")]
        public string KuDE { get; set; }
        [XmlElement(ElementName = "xmlFirmado", Namespace = "http://ws.efactura.isaltda.py/")]
        public string xmlFirmado { get; set; }
    }
    [XmlRoot(ElementName = "return", Namespace = "http://ws.efactura.isaltda.py/")]
    public class Return
    {
        [XmlElement(ElementName = "ok", Namespace = "http://ws.efactura.isaltda.py/")]
        public string Ok { get; set; }
        [XmlElement(ElementName = "mensajeError", Namespace = "http://ws.efactura.isaltda.py/")]
        public string MensajeError { get; set; }
        [XmlElement(ElementName = "numDocumentoError", Namespace = "http://ws.efactura.isaltda.py/")]
        public string NumDocumentoError { get; set; }
        [XmlElement(ElementName = "documentoElectronicoGenerado", Namespace = "http://ws.efactura.isaltda.py/")]
        public DocumentoElectronicoGenerado DocumentoElectronicoGenerado { get; set; }
    }
    [XmlRoot(ElementName = "procesarLotePorFacturaResponse", Namespace = "http://ws.efactura.isaltda.py/")]
    public class procesarLotePorFacturaResponse
    {
        [XmlElement(ElementName = "return", Namespace = "http://ws.efactura.isaltda.py/")]
        public Return Return { get; set; }
        [XmlAttribute(AttributeName = "ns2", Namespace = "http://ws.efactura.isaltda.py/")]
        public string Ns2 { get; set; }
    }
    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class procesarLotePorFacturaResponseBody
    {
        [XmlElement(ElementName = "procesarLoteFacturasReponse", Namespace = "http://ws.efactura.isaltda.py/")]
        public procesarLotePorFacturaResponse procesarLoteFacturasReponse { get; set; }
    }
    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class procesarLotePorFacturaResponseEnvelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public string Header { get; set; }
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public procesarLotePorFacturaResponseBody Body { get; set; }
        [XmlAttribute(AttributeName = "SOAP-ENV", Namespace = "")]
        public string SOAPENV { get; set; }
    }
}
