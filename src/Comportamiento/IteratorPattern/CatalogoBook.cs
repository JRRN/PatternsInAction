namespace IteratorPattern
{
    public class CatalogoBook : Catalogo<BookIterator, IteradorBook>
    {
        public CatalogoBook()
        {
            contenido.Add(new BookIterator("Libro PDF"));
            contenido.Add(new BookIterator("Gran libro en PDF"));
            contenido.Add(new BookIterator("Libro de gran calidad"));
        }
    }
}