using DecoratorPattern;

namespace PatternsInAction.Estructura
{
    class Decorator
    {
        public  static void Show()
        {
            Books libro = new Books();
            EditorialTecnologicaDecorador editorialTechlDecorador = new EditorialTecnologicaDecorador(libro);
            AutorTecnologicoDecorador autorTechDecorador = new AutorTecnologicoDecorador(libro);
            autorTechDecorador.VerCatalogo();
            editorialTechlDecorador.VerCatalogo();
        }
    }
}