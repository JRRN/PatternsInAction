using System;

namespace DecoratorPattern
{
    public class EditorialTecnologicaDecorador : Decorador
    {
        public EditorialTecnologicaDecorador(ICatalogo catalogo) : base(catalogo) { }

        protected void VisualizaEditorialLibrosTecnicos()
        {
            Console.WriteLine("Editorial libro técnico.");
        }

        public override void VerCatalogo()
        {
            base.VerDatosLibro();
            VisualizaEditorialLibrosTecnicos();
        }
    }
}