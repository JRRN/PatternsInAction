using System;

namespace FacadePattern
{
    public interface IFacadeService
    {
        void GetCatalogo();
        void GetBookById(Guid id);
        void GetPedidoById(Guid id);
    }
}