namespace BuilderPattern
{
    public abstract class ConstructorDocumentacion
    {
        protected Documentacion documentacion;
        public abstract void ConstruyeSolicitudPedido(string nombreCliente);
        public abstract void ConstruyeSolicitudFactura(string nombreSolicitante);
        public Documentacion Resultado()
        {
            return documentacion;
        }
    }
}