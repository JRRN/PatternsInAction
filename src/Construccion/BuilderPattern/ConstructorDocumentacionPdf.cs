namespace BuilderPattern
{
    public class ConstructorDocumentacionPdf : ConstructorDocumentacion
    {
        public ConstructorDocumentacionPdf()
        {
            documentacion = new DocumentacionPdf();
        }

        public override void ConstruyeSolicitudPedido(string nombreCliente)
        {
            string documento;
            documento = $"<PDF>Solicitud de pedido Cliente: {nombreCliente} </PDF>";
            documentacion.AgregaDocumento(documento);
        }

        public override void ConstruyeSolicitudFactura(string nombreSolicitante)
        {
            string documento;
            documento = $"<PDF>Solicitud de factura Solicitante: {nombreSolicitante}</PDF>";
            documentacion.AgregaDocumento(documento);
        }
    }
}