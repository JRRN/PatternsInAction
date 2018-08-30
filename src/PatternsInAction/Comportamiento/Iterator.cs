using IteratorPattern;

namespace PatternsInAction.Comportamiento
{
    class Iterator
    {
        public  static void Show()
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
    }
}