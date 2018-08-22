using System;

namespace IteratorPattern
{
    public class BookIterator : Item
    {
        public BookIterator(string descripcion) : base(descripcion) { }

        public void Visualiza()
        {
            Console.WriteLine($"Descripción del Libro: { _descripcion}");
        }
    }
}