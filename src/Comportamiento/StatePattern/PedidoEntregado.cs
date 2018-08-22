namespace StatePattern
{
    public class PedidoEntregado : EstadoPedido
    {
        public PedidoEntregado(PedidoState pedido) : base(pedido) { }

        public override void AgregaProducto(ProductoState producto) { }

        public override void QuitaTodo() { }

        public override void QuitaProducto(ProductoState producto) { }
    
        public override EstadoPedido EstadoSiguiente()
        {
            return this;
        }
    }
}