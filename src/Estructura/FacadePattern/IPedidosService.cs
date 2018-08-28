using System;

namespace FacadePattern
{
    public interface IPedidosService
    {
        void GetPedidoById(Guid pedido);
    }
}