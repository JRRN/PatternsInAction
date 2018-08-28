namespace BuilderPattern
{
    public class Vendedor
    {
        protected ConstructorDocumentacion constructor;

        public Vendedor(ConstructorDocumentacion constructor)
        {
            this.constructor = constructor;
        }

        public Documentacion Construye(string nombreCliente)
        {
            constructor.ConstruyeSolicitudPedido(nombreCliente);
            constructor.ConstruyeSolicitudFactura(nombreCliente);
            Documentacion documentacion = constructor.Resultado();
            return documentacion;
        }
    }
}