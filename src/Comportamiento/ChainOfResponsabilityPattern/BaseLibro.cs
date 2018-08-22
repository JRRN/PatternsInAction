using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityPattern
{
    public abstract class BaseLibro
    {
        public BaseLibro siguiente { protected get; set; }

        private static string DescripcionBase()
        {
            return "Descripción base: Es un libro.";
        }

        protected abstract string descripcion { get; }

        public string GetDescripcion()
        {
            var result = descripcion;

            if (result != null)
            {
                return result;
            }
            return siguiente != null ? siguiente.GetDescripcion() : DescripcionBase();
        }
    }
}
