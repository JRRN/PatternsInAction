using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class PaperBook : Book
    {
        public PaperBook(string titulo, string autor, int añoPublicacion, FormatType formatType)
            : base(titulo, autor, añoPublicacion, formatType) { }
        public override void mostrarCaracteristicas()
        {
            Console.WriteLine($"Datos del libro físico: {titulo} del autor: {autor} publicado el: {añoPublicacion} en formato: {formatType}");
        }
    }
}
