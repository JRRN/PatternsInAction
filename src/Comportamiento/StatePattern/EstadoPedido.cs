namespace StatePattern
{
    public abstract class EstadoPedido
    {
        protected PedidoState Pedido;

        protected EstadoPedido(PedidoState pedido)
        {
            Pedido = pedido;
        }

        public abstract void AgregaProducto(ProductoState producto);
        public abstract void QuitaTodo();
        public abstract void QuitaProducto(ProductoState producto);
        public abstract EstadoPedido EstadoSiguiente();
    }
}