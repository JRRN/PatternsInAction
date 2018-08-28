using System;

namespace FacadePattern
{
    public class BookService : IBookService
    {
        public void GetBookById(Guid id)
        {
            Console.WriteLine($"Datos del libro: {id}");
        }
    }
}