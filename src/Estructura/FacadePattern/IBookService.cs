using System;

namespace FacadePattern
{
    public interface IBookService
    {
        void GetBookById(Guid book);
    }
}