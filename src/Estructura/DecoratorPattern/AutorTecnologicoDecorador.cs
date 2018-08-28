using System;

namespace DecoratorPattern
{
    public class AutorTecnologicoDecorador : Decorador
    {
        public AutorTecnologicoDecorador(ICatalogo catalogo) : base(catalogo) { }

        protected void VisualizaAutorLibrosTecnicos()
        {
            Console.WriteLine("Autor técnico.");
        }

        public override void VerCatalogo()
        {
            base.VerDatosLibro();
            VisualizaAutorLibrosTecnicos();
        }
    }
}