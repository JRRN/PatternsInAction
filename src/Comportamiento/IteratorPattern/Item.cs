using System;

namespace IteratorPattern
{
    public abstract class Item
    {
        protected string _descripcion;

        protected Item(string descripcion)
        {
            _descripcion = descripcion;
        }

        public bool PalabraClaveValida(string palabraClave) 
            => _descripcion.IndexOf(palabraClave, StringComparison.Ordinal) != -1;
    }
}
