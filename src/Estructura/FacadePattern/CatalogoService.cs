using System;

namespace FacadePattern
{
    public class CatalogoService : ICatalagoService
    {
        public void GetCatalogo()
        {
            Console.WriteLine("Contenido del Catalógo");
        }
    }
}
