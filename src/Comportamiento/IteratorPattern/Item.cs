using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        {
            return _descripcion.Contains(palabraClave);
        }
    }
}
