using System;
using System.Collections.Generic;

namespace StatePattern
{
    public class PedidoState
    {
        protected IList<ProductoState> productos = new List<ProductoState>();

        public IList<ProductoState> Productos => productos;

        protected EstadoPedido EstadoPedido;

        public PedidoState() {
            EstadoPedido = new PedidoEnCurso(this);
        }

        public void AgregaProducto(ProductoState producto)
        {
            EstadoPedido.AgregaProducto(producto);
        }

        public void QuitaProducto(ProductoState producto)
        {
            EstadoPedido.QuitaProducto(producto);
        }

        public void QuitaTodo()
        {
            EstadoPedido.QuitaTodo();
        }

        public void EstadoSiguiente()
        {
            EstadoPedido = EstadoPedido.EstadoSiguiente();
        }

        public void Imprime()
        {
            Console.WriteLine("Contenido del pedido:");
            foreach (var producto in Productos)
            {
                producto.Imprime();
            }

            Console.WriteLine();
        }
    }
}
