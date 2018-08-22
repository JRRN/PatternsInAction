using System;

namespace StatePattern
{
    public class ProductoState
    {
        protected string Nombre;

        public ProductoState(string nombre)
        {
            Nombre = nombre;
        }

        public void Imprime()
        {
            Console.WriteLine($"Producto: {Nombre}");
        }
    }
}