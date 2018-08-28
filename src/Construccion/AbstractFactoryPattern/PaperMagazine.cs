using System;

namespace AbstractFactoryPattern
{
    public class PaperMagazine :Magazine
    {
        public PaperMagazine(string titulo, int añoPublicacion, FormatType formatType) : base(titulo, añoPublicacion, formatType)
        {
        }
        public override void MostrarCaracteristicas() 
            => Console.WriteLine($"Magazine {_titulo} del año {_añoPublicacion} en formato {_formatType} ");
    }
}