using AdapterPattern;

namespace PatternsInAction.Estructura
{
    class Adapter
    {
        public  static void Show()
        {
            IBookAdapter paperBook = new PaperBook { Contenido = "Soy un libro físico"};
            paperBook.Compone();
            paperBook.Imprime();
            paperBook.Enviar();

            IBookAdapter mediaBook = new PdfBook {Contenido = "Soy un libro digital"};
            mediaBook.Compone();
            mediaBook.Imprime();
            mediaBook.Enviar();
        }
    }
}