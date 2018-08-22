using System;
using MementoPattern;
using ObserverPattern;
using StatePattern;
using StrategyPattern;
using TemplateMethodPattern;
using VisitorPattern;


namespace PatternsInAction
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitorPattern();
            Console.WriteLine(); TemplateMethodPattern();

            Console.WriteLine(); StatePattern();
            Console.WriteLine(); StrategyPattern();
            Console.WriteLine(); Observer();
            Console.WriteLine(); Memento();
            Console.ReadLine();
        }


        private static void VisitorPattern()
        {
            Editorial editorial1 = new EditorialSinFilial("empresa1", "mail@empresa1.com", "Calle Empresa 1");
            Editorial editorial2 = new EditorialSinFilial("empresa2", "mail@empresa2.com", "Calle Empresa 2");

            Editorial grupoEditorial =
                new EditorialMadre("grupoEditorial1", "mail@grupoEditorial1.com", "Calle Grupo Editorial1");

            grupoEditorial.AgregarEditorialFilial(editorial1);
            grupoEditorial.AgregarEditorialFilial(editorial2);

            Editorial editorial3 = new EditorialSinFilial("empresa3", "mail@empresa3.com", "Calle Empresa 3");

            Editorial grupoEditorial2 = new EditorialMadre("grupoEditorial2", "mail@grupoEditorial2.com", "Calle Grupo Editorial2");

            grupoEditorial2.AgregarEditorialFilial(grupoEditorial);
            grupoEditorial2.AgregarEditorialFilial(editorial3);

            grupoEditorial2.AceptaVisitante(new VisitanteMailingComercial());

        }

        private static void TemplateMethodPattern()
        {
            Pedido pedidoEspaña = new PedidoEspaña();
            pedidoEspaña.SetImporteSinIva(1000);
            pedidoEspaña.CalcularIva();
            pedidoEspaña.CalculaPrecioTotal();
            pedidoEspaña.Imprime();

            Pedido pedidoMexico = new PedidoMexico();
            pedidoMexico.SetImporteSinIva(1000);
            pedidoMexico.CalcularIva();
            pedidoMexico.CalculaPrecioTotal();
            pedidoMexico.Imprime();
        }

        private static void StatePattern()
        {
            PedidoState pedido = new PedidoState();
            pedido.AgregaProducto(new ProductoState("Book 1"));
            pedido.AgregaProducto(new ProductoState("Book 2"));
            pedido.Imprime();
            pedido.EstadoSiguiente();
            pedido.AgregaProducto(new ProductoState("Book 3"));
            pedido.QuitaTodo();
            pedido.Imprime();

            PedidoState pedido2 = new PedidoState();
            pedido2.AgregaProducto(new ProductoState("Book 10"));
            pedido2.AgregaProducto(new ProductoState("Book 20"));
            pedido2.Imprime();
            pedido2.EstadoSiguiente();
            pedido2.Imprime();
            pedido2.EstadoSiguiente();
            pedido2.QuitaTodo(); //En este estado no hará nada
            pedido2.Imprime();
        }

        private static void StrategyPattern()
        {
            IBookCalculaIva _calculaIvaEsp = new CalculaBookIvaEspaña();
            IBookCalculaIva _calculaIvaMex = new CalculaBookIvaMexico();

            _calculaIvaEsp.CalculaIva(new CalculaBookIvaEspaña().CalculaIva(10));
            _calculaIvaEsp.ImprimeResultado();

            _calculaIvaMex.CalculaIva(new CalculaBookIvaMexico().CalculaIva(10));
            _calculaIvaMex.ImprimeResultado();
        }

        private static void Observer()
        {
            Book book = new Book
            {
                Descripcion = "Libro de IT",
                Precio = "10"
            };

            BookView bookView = new BookView(book);
            bookView.Imprime();

            book.Descripcion = "Libro de IT Barato";

            BookView bookView2 = new BookView(book);
            book.Descripcion = "Libro de IT Muy Barato";
            bookView2.Imprime();
        }

        private static void Memento()
        {
            IMemento memento;

            OpcionBook op1 = new OpcionBook("Tapa dura");
            OpcionBook op2 = new OpcionBook("Tapa Blanda");
            OpcionBook op3 = new OpcionBook("Tapa Encuadernado");

            op1.AgregaOpcionIncompatible(op3);
            op2.AgregaOpcionIncompatible(op3);

            CompraOpciones compraOpciones = new CompraOpciones();
            compraOpciones.AgregaOpciones(op1);
            compraOpciones.AgregaOpciones(op2);
            compraOpciones.Visualiza();

            compraOpciones.Anula(memento);
            compraOpciones.Visualiza();
        }
    }
}
