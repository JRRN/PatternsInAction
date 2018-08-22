using System;

namespace ObserverPattern
{
    public class BookView : IObserver
    {
        protected Book book;
        protected string texto = String.Empty;

        public BookView(Book book)
        {
            this.book = book;
            book.Agrega(this);
            ActualizaTexto();
        }

        protected void ActualizaTexto()
        {
            texto = $"Descripción {book.Descripcion}, precio {book.Precio}";
        }

        public void Actualiza()
        {
            ActualizaTexto();
            this.Imprime();
        }

        public void Imprime()
        {
            Console.WriteLine(texto);
        }
    }
}