﻿using System;
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
        public override void MostrarCaracteristicas()
            => Console.WriteLine($"Datos del libro físico: {_titulo} del autor: {_autor} publicado el: {_añoPublicacion} en formato: {_formatType}");
    }
}
