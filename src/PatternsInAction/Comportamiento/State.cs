using StatePattern;

namespace PatternsInAction.Comportamiento
{
    class State
    {
        public  static void Show()
        {
            PedidoState pedido = new PedidoState();
            pedido.AgregaProducto(new ProductoState("Book 1"));
            pedido.AgregaProducto(new ProductoState("Book 2"));
            pedido.Imprime();
            pedido.EstadoSiguiente();
            pedido.AgregaProducto(new ProductoState("Book 3"));
            pedido.QuitaTodo();
            pedido.Imprime();

            PedidoState pedido2 = new PedidoState();
            pedido2.AgregaProducto(new ProductoState("Book 10"));
            pedido2.AgregaProducto(new ProductoState("Book 20"));
            pedido2.Imprime();
            pedido2.EstadoSiguiente();
            pedido2.Imprime();
            pedido2.EstadoSiguiente();
            pedido2.QuitaTodo(); //En este estado no hará nada
            pedido2.Imprime();
        }
    }
}