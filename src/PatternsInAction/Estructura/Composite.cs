using System;
using CompositePattern;

namespace PatternsInAction.Estructura
{
    class Composite
    {
        public  static void Show()
        {
            Cliente clienteFinal = new ClienteFinal();
            clienteFinal.AnadirLibro();

            Cliente otroClienteFinal = new ClienteFinal();
            otroClienteFinal.AnadirLibro();
            otroClienteFinal.AnadirLibro();

            Cliente editorialCliente = new EditorialCliente();
            editorialCliente.AgregarEditorial(clienteFinal);
            editorialCliente.AgregarEditorial(otroClienteFinal);
            editorialCliente.AnadirLibro();

            Console.WriteLine($"Total pedidos clientes: { editorialCliente.CalcularPedido() }");
        }
    }
}