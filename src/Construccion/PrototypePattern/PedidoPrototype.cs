using System;

namespace PrototypePattern
{
    public class PedidoPrototype : Documento
    {
        public override void Visualiza() => Console.WriteLine($"Pedido: {contenido}");

        public override void Imprime() => Console.WriteLine($"Imprime Pedido: {contenido}");
    }
}