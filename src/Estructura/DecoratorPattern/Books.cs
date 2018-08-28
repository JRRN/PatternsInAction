using System;

namespace DecoratorPattern
{
    public class Books : ICatalogo
    {
        public void VerDatosLibro()
        {
            Console.WriteLine("Mostrando Libro");
        }
    }
}
