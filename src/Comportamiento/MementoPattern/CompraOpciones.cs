using System;
using System.Collections.Generic;

namespace MementoPattern
{
    public class CompraOpciones
    {
        protected IList<OpcionBook> bookOptions = new List<OpcionBook>();

        public IMemento AgregaOpciones(OpcionBook bookOption)
        {
            MementoImplementation result = new MementoImplementation();
            result.State = bookOptions;

            IList<OpcionBook> bookOptionsNotSupported = bookOption.BookOptionsNotSupported;

            foreach (OpcionBook bOption in bookOptionsNotSupported)
            {
                bookOptions.Remove(bOption);
            }

            bookOptions.Add(bookOption);

            return result;
        }

        public void Anula(IMemento memento)
        {
            if (!(memento is MementoImplementation mementoImplementation))
            {
                return;
            }

            bookOptions = mementoImplementation.State;
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