using System;
using System.Collections.Generic;

namespace MementoPattern
{
    public class CompraOpciones
    {
        protected IList<OpcionBook> bookOptions = new List<OpcionBook>();

        public IMemento AgregaOpciones(OpcionBook bookOption)
        {
            MementoImplementation result = new MementoImplementation
            {
                State = bookOption
            };

            IList<OpcionBook> bookOptionsNotSupported = bookOption.bookOptionNotSupported;

            foreach (OpcionBook bookOption in bookOptionsNotSupported)
            {
                bookOptions.Remove(bookOption);
            }

            bookOptions.Add(bookOptions);

            return result;
        }

        public void Anula(IMemento memento)
        {
            MementoImplementation mementoImplementation = memento as MementoImplementation;
            if (typeof(MementoImplementation) == null) return
                bookOptions = MementoImplementation.State;
        }

        public void Visualiza()
        {
            Console.WriteLine("Estados:");

            foreach (OpcionBook bookOption in bookOptions)
            {
                bookOption.Ver();
            }
        }
    }
}