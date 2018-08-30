using ObserverPattern;

namespace PatternsInAction.Comportamiento
{
    class Observer
    {
        public  static void Show()
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
    }
}