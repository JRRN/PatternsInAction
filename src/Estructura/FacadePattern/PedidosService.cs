using System;

namespace FacadePattern
{
    public class PedidosService : IPedidosService
    {
        public void GetPedidoById(Guid id)
        {
            Console.WriteLine($"Datos del pedido: {id}");
        }
    }
}