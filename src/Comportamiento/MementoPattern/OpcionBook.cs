using System;
using System.Collections.Generic;

namespace MementoPattern
{
    public class OpcionBook
    {
        protected string _nombre;
        public IList<OpcionBook> BookOptionsNotSupported { get; protected set; }

        public OpcionBook(string nombre)
        {
            BookOptionsNotSupported = new List<OpcionBook>();
            _nombre = nombre;
        }

        public void AgregaOpcionIncompatible(OpcionBook bookOptionIncompatible)
        {
            if (!BookOptionsNotSupported.Contains(bookOptionIncompatible))
            {
                BookOptionsNotSupported.Add(bookOptionIncompatible);
                bookOptionIncompatible.AgregaOpcionIncompatible(this);
            }
        }

        public void Ver() => Console.WriteLine($"opcion : {_nombre}");
    }
}