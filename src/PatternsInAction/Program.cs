//using MediatorPattern;
using ObserverPattern;
using StatePattern;
using StrategyPattern;
using System;
using AdapterPattern;
using BridgePattern;
using IteratorPattern;
using TemplateMethodPattern;
using VisitorPattern;
using InterpreterPattern;
using BridgePattern;
using BuilderPattern;
using CompositePattern;
//using CompositePattern;
using DecoratorPattern;
using FacadePattern;
using FactoryMethodPattern;
using FlyweightPattern;
using MementoPattern;
using PrototypePattern;
using SingletonPattern;
using DocumentosVacios = PrototypePattern.DocumentosVacios;
using Pedido = TemplateMethodPattern.Pedido;
using TipoLibroEnum = BridgePattern.TipoLibroEnum;


namespace PatternsInAction
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitorPattern();
            Console.WriteLine("Template Method Pattern"); TemplateMethodPattern();

            Console.WriteLine("State Patterns"); StatePattern();
            Console.WriteLine("Strategy Pattern"); StrategyPattern();
            Console.WriteLine("Observer Pattern"); Observer();
            Console.WriteLine("Memento Pattern"); Memento();
            //Console.WriteLine("Mediator Pattern"); Mediator();
            Console.WriteLine("Iterator Pattern"); Iterator();

            Console.WriteLine("Interpreter Pattern"); Interpreter();
            Console.WriteLine("Adapter Pattern");Adapter();
            Console.WriteLine("Bridge Pattern"); Bridge();
            Console.WriteLine("Composite Pattern"); Composite();
            Console.WriteLine("Decorator Pattern"); Decorator();
            Console.WriteLine("Facade Pattern"); Facade();
            Console.WriteLine("Flyweight Pattern"); Flyweight();
            //Console.WriteLine("Proxy Pattern"); Proxy();
            Console.WriteLine("Singleton Pattern"); Singleton();
            Console.WriteLine("Builder Pattern"); Builder();
            Console.WriteLine("Factory Method Pattern"); FactoryMethod();
            Console.WriteLine("Prototype Pattern"); Prototype();

            Console.ReadLine();
        }

        private static void Prototype()
        {
            DocumentosVacios documentosVacios = DocumentosVacios.Instance();
            documentosVacios.Incluye(new PedidoPrototype());
            documentosVacios.Incluye(new FacturaPrototype());
            documentosVacios.Incluye(new LibroDigital());
            DocumentosCliente documentoCliente = new DocumentosCliente("Un usuario");
            DocumentosCliente documentoCliente2 = new DocumentosCliente("Otro Usuario");
            documentoCliente.Visualiza();
            documentoCliente2.Visualiza();
        }

        private static void FactoryMethod()
        {
            PedidoTargeta pedidoEfectivo = new PedidoTargeta(100);
            if (pedidoEfectivo.Valida()) { pedidoEfectivo.Paga();}
            
            PedidoTargeta pedidoTargetaNoValido = new PedidoTargeta(1000);
            if (pedidoTargetaNoValido.Valida()) { pedidoTargetaNoValido.Paga(); }

            PedidoTargeta pedidoTargetaValido = new PedidoTargeta(50);
            if (pedidoTargetaValido.Valida()) { pedidoTargetaValido.Paga(); }
        }

        private static void Builder()
        {
            ConstructorDocumentacion constructor;
            Console.WriteLine("Desea generar documentación HTML (1) o PDF (2):");
            string seleccion = Console.ReadLine();
            if (seleccion == "1")
            {
                constructor = new ConstructorDocumentacionHtml();
            }
            else
            {
                constructor = new ConstructorDocumentacionPdf();
            }
            Vendedor vendedor = new Vendedor(constructor);
            Documentacion documentacion = vendedor.Construye("JRRN");
            documentacion.Imprime();
        }

        private static void Singleton()
        {
            EditorialSingleton laEditorial = EditorialSingleton.Instance();
            laEditorial.nombreEditorial = "JRRN Publicaciones";
            laEditorial.ubicacion = "Barcelona";
            laEditorial.fechaEditorial = new DateTime(2018,05,11);

            EditorialSingleton _laEditorial = EditorialSingleton.Instance();
            _laEditorial.Visualiza();
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
            OpcionBook op1 = new OpcionBook("Tapa dura");
            OpcionBook op2 = new OpcionBook("Tapa Blanda");
            OpcionBook op3 = new OpcionBook("Tapa Encuadernado");

            op1.AgregaOpcionIncompatible(op3);
            op2.AgregaOpcionIncompatible(op3);

            CompraOpciones compraOpciones = new CompraOpciones();
            compraOpciones.AgregaOpciones(op1);
            compraOpciones.AgregaOpciones(op2);
            compraOpciones.Visualiza();

            var memento = compraOpciones.AgregaOpciones(op3);
            compraOpciones.Visualiza();
            compraOpciones.Anula(memento);
            compraOpciones.Visualiza();
        }

        private static void Mediator()
        {
            //TorreDeControl torreControl = new TorreDeControl();
            //new Productor(torreControl).Run();
            //new Productor(torreControl).Run();
            //new Consumidor(torreControl).Run();
            //new Consumidor(torreControl).Run();
            //new Consumidor(torreControl).Run();
            //new Consumidor(torreControl).Run();
        }

        private static void Iterator()
        {
            CatalogoBook catalogo = new CatalogoBook();
            IteradorBook iterador = catalogo.Busqueda("PDF");
            BookIterator libro;
            iterador.Inicio();
            libro = iterador.item();
            while (libro != null)
            {
                libro.Visualiza();
                iterador.Siguiente();
                libro = iterador.item();
            }
        }

        private static void Interpreter()
        {
            //Expresion expresionConsulta = null;
            //Console.Write("Introduzca su consulta: ");
            //string consulta = Console.ReadLine();
            //try
            //{
            //    expresionConsulta = Expresion.Analiza(consulta);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    expresionConsulta = null;
            //}
            //if (expresionConsulta != null)
            //{
            //    Console.WriteLine("Introduzca la descripción: ");
            //    string descripcion = Console.ReadLine();
            //    Console.WriteLine(expresionConsulta.Evalua(descripcion)
            //        ? "La descripción responde a la consulta"
            //        : "La descripción no responde a la consulta");
            //}
        }

        private static void Adapter()
        {
            IBookAdapter paperBook = new AdapterPattern.PaperBook { Contenido = "Soy un libro físico"};
            paperBook.Compone();
            paperBook.Imprime();
            paperBook.Enviar();

            IBookAdapter mediaBook = new PdfBook {Contenido = "Soy un libro digital"};
            mediaBook.Compone();
            mediaBook.Imprime();
            mediaBook.Enviar();
        }

        private static void Bridge()
        {
            GeneradorLibroElectronico libroElectronico = new GeneradorLibroElectronico(new BridgePattern.MediaBook());

            Console.WriteLine(libroElectronico._tipoLibroEnum);
            if (libroElectronico.TipoDeLibro() == TipoLibroEnum.Media)
            {
                libroElectronico.Genera();
            }

            GeneradorLibroPapel libroPapel = new GeneradorLibroPapel(new BridgePattern.PaperBook());

            Console.WriteLine(libroPapel._tipoLibroEnum);
            if (libroPapel.TipoDeLibro() == TipoLibroEnum.Paper)
            {
                libroPapel.Genera();
            }
        }

        private static void Composite()
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

        private static void Decorator()
        {
            DecoratorPattern.Books libro = new DecoratorPattern.Books();
            EditorialTecnologicaDecorador editorialTechlDecorador = new EditorialTecnologicaDecorador(libro);
            AutorTecnologicoDecorador autorTechDecorador = new AutorTecnologicoDecorador(libro);
            autorTechDecorador.VerCatalogo();
            editorialTechlDecorador.VerCatalogo();
        }

        private static void Facade()
        {
            IFacadeService _facade = new FacadeService();

            _facade.GetCatalogo();
            
            _facade.GetBookById(Guid.NewGuid());

            _facade.GetPedidoById(Guid.NewGuid());
        }

        private static void Flyweight()
        {
            DeterminaOpcion opcion = new DeterminaOpcion();
            LibroPedido libroPedido = new LibroPedido();

            libroPedido.AgregaOpcionLibro(FlyweightPattern.TipoLibroEnum.Anillas, 10, opcion);
            libroPedido.AgregaOpcionLibro(FlyweightPattern.TipoLibroEnum.Encolado, 30, opcion);

            libroPedido.MuestraOpciones();
        }

        //private static void Proxy()
        //{
        //    IBook book = new DescripcionProxy();

        //    book.Renderiza();
        //    book.CargaDescripcion();
        //    book.Renderiza();
        //}
    }
}
