using AbstractFactoryPattern;

namespace PatternsInAction.Construccion
{
    class AbstractFactory
    {
        public  static void Show()
        {
            int nBooks = 3;
            int nMagazines = 2;

            IFactory fabrica  = new Factory();
            Book[] books = new Book[nBooks];
            Magazine[] magazines = new Magazine [nMagazines];

            for (int index = 0; index < nBooks; index++)
            {
                var formatType = index == 0 ? FormatType.Paper : FormatType.Media;
                books[index] = fabrica.NewBook("Papel","Autor", 1980, formatType);
            }
                
            for (int index = 0; index < nMagazines; index++){
                var formatType = index == 0 ? FormatType.Paper : FormatType.Media;
                magazines[index] = fabrica.NewMagazine("Papel", 1981, formatType);
            }
           
            foreach (Book book in books)
                book.MostrarCaracteristicas();
            foreach (Magazine magazine in magazines)
                magazine.MostrarCaracteristicas();
        }
    }
}