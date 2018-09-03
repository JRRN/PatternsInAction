using System;
using CommandPattern;
using IteratorPattern;

namespace PatternsInAction.Comportamiento
{
    public class Command
    {
        public static void Show()
        {
            BookCommand vehiculo1 = new BookCommand("LIBRO 1", DateTime.Now, 1000.0);
            BookCommand vehiculo2 = new BookCommand("LIBRO 2", DateTime.Now.AddDays(-1), 2000.0);
            BookCommand vehiculo3 = new BookCommand("LIBRO 3", DateTime.Now.AddDays(-2), 3000.0);

            CatalogoCommand catalogo = new CatalogoCommand();
            catalogo.Agrega(vehiculo1);
            catalogo.Agrega(vehiculo2);
            catalogo.Agrega(vehiculo3);

            Console.WriteLine("Visualización inicial del catálogo");
            catalogo.Visualiza();
            Console.WriteLine();

            AplicarRebaja solicitudRebaja = new AplicarRebaja(10, 0.1);
            catalogo.commandRebaja(solicitudRebaja);

            Console.WriteLine("Visualización del catálogo tras ejecutar la primera solicitud");
            catalogo.Visualiza();
            Console.WriteLine();

            AplicarRebaja solicitudRebaja2 = new AplicarRebaja(10, 0.5);
            catalogo.commandRebaja(solicitudRebaja2);
            Console.WriteLine("Visualización del católogo tras ejecutar la segunda solicitud");
            catalogo.Visualiza();
            Console.WriteLine();

            catalogo.CommandAnulaRebaja(1);
            Console.WriteLine("Visualización del católogo tras anular la primera solicitud");
            catalogo.Visualiza();
            Console.WriteLine();

            catalogo.RestablecerSolicitudRebaja(1);
            Console.WriteLine("Visualización del catálogo tras restablecer la primera solicitud");
            catalogo.Visualiza();
            Console.WriteLine();
        }
    }
}