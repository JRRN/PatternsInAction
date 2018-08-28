namespace BuilderPattern
{
    public class ConstructorDocumentacionHtml : ConstructorDocumentacion
    {
        public ConstructorDocumentacionHtml()
        {
            documentacion = new DocumentacionHtml();
        }

        public override void ConstruyeSolicitudPedido(string nombreCliente)
        {
            string documento;
            documento = $"Solicitud de pedido Cliente: {nombreCliente} HTML";
            documentacion.AgregaDocumento(documento);
        }

        public override void ConstruyeSolicitudFactura(string nombreSolicitante)
        {
            string documento;
            documento = $"HTML Solicitud de factura Solicitante:  {nombreSolicitante}";

            documentacion.AgregaDocumento(documento);
        }

    }
}