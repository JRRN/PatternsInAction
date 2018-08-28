using System;

namespace PrototypePattern
{
    public class LibroDigital : Documento
    {
        public override void Visualiza()
        {
            Console.WriteLine($"LibroDigital: {contenido}");
        }
        public override void Imprime()
        {
            Console.WriteLine($"Imprime LibroDigital: {contenido}");
        }
    }
}