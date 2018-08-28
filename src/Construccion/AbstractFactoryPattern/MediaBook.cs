using System;

namespace AbstractFactoryPattern
{
    public class MediaBook : Book
    {
        public MediaBook(string titulo, string autor, int añoPublicacion, FormatType formatType)
            : base(titulo, autor, añoPublicacion, formatType) { }

        public override void mostrarCaracteristicas()
        {
            Console.WriteLine($"Datos del libro físico:{titulo} del autor: {autor} publicado el: {añoPublicacion} en formato: {formatType}");
        }

    }
}