using System;

namespace FacadePattern
{
    public class FacadeService : IFacadeService
    {
        private readonly ICatalagoService _catalogo = new CatalogoService();
        private readonly IBookService _book = new BookService();
        private readonly IPedidosService _pedido = new PedidosService();

        public void GetCatalogo()
        {
            _catalogo.GetCatalogo();
        }

        public void GetBookById(Guid id)
        {
            _book.GetBookById(id);
        }

        public void GetPedidoById(Guid id)
        {
            _pedido.GetPedidoById(id);
        }

    }
}