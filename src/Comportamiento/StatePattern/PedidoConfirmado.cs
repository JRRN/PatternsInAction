namespace StatePattern
{
    public class PedidoConfirmado : EstadoPedido
    {
        public PedidoConfirmado(PedidoState pedido) : base(pedido)
        {
        }

        public override void AgregaProducto(ProductoState producto)
        {
        }

        public override void QuitaTodo()
        {
            Pedido.Productos.Clear();
        }

        public override void QuitaProducto(ProductoState producto)
        {
        }

        public override EstadoPedido EstadoSiguiente()
        {
            return new PedidoEntregado(Pedido);
        }
    }
}