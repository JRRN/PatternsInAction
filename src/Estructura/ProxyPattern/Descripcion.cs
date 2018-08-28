using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Descripcion : IBook
    {
        public void Renderiza()
        {
            Console.WriteLine("Muestra Descripción");
        }

        public void CargaDescripcion()
        {
            Console.WriteLine("Carga descripción");
        }

        public void MuestraDescripcion()
        {
            Console.WriteLine("Mostrando Descripción");
        }
    }
}
