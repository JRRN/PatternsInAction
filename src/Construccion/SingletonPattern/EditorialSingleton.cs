using System;

namespace SingletonPattern
{
    public class EditorialSingleton
    {
        public string nombreEditorial  { get; set; }
        public string ubicacion  { get; set; }
        public DateTime fechaEditorial  { get; set; }
        private static EditorialSingleton _instance = null;

        private EditorialSingleton() { }
        public static EditorialSingleton Instance()
        {
            return _instance ?? (_instance = new EditorialSingleton());
        }
        public void Visualiza()
        {
            Console.WriteLine($"Editorial:  {nombreEditorial}");
            Console.WriteLine($"Ubicacion:  {ubicacion}");
        }
    }
}