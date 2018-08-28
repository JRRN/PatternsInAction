using System;

namespace AbstractFactoryPattern
{
    public class MediaBook : Book
    {
        public MediaBook(string titulo, string autor, int añoPublicacion, FormatType formatType)
            : base(titulo, autor, añoPublicacion, formatType) { }

        public override void MostrarCaracteristicas() 
            => Console.WriteLine($"Datos del libro físico:{_titulo} del autor: {_autor} publicado el: {_añoPublicacion} en formato: {_formatType}");
    }
}