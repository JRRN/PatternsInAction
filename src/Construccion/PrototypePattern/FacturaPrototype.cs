using System;

namespace PrototypePattern
{
    public class FacturaPrototype : Documento
    {
        public override void Visualiza()
        {
            Console.WriteLine($"Factura: {contenido}");
        }
        public override void Imprime()
        {
            Console.WriteLine($"Imprime Factura: {contenido}");
        }
    }
}