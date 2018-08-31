using System;
using ChainOfResponsabilityPattern;

namespace PatternsInAction.Comportamiento
{
    class ChainOfResponsability
    {
        public static void Show()
        {
            BaseLibro libroBase = new LibroCoR("Libro de IT de patrones");
            Console.WriteLine(libroBase.GetDescripcion());

            BaseLibro modelo1 = new LibroCategoriaDescripcion("Libro IT", "Libro para desarrolladores");
            BaseLibro libro2 = new LibroCoR(null);
            libro2.siguiente = modelo1;
            Console.WriteLine(libro2.GetDescripcion());

            BaseLibro marca1 = new LibroDescripcion("Libro IT Tapa Dura", "TIPO");
            BaseLibro modelo2 = new LibroCategoriaDescripcion("Tecnología", null);
            modelo2.siguiente = marca1;

            BaseLibro vehiculo3 = new LibroCoR(null);
            vehiculo3.siguiente = modelo2;
            Console.WriteLine(vehiculo3.GetDescripcion());

            BaseLibro vehiculo4 = new LibroCoR(null);
            Console.WriteLine(vehiculo4.GetDescripcion());
        }
    }
}