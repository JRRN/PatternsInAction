namespace StatePattern
{
    public class PedidoEnCurso : EstadoPedido
    {
        public PedidoEnCurso(PedidoState pedido) : base(pedido)
        {
        }

        public override void AgregaProducto(ProductoState producto)
        {
            Pedido.Productos.Add(producto);
        }

        public override void QuitaTodo()
        {
            Pedido.Productos.Clear();
        }

        public override void QuitaProducto(ProductoState producto)
        {
            Pedido.Productos.Remove(producto);
        }

        public override EstadoPedido EstadoSiguiente()
        {
            return new PedidoConfirmado(Pedido);
        }
    }
}