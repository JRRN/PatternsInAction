using System.Collections.Generic;

namespace MementoPattern
{
    public class MementoImplementation : IMemento
    {
        protected IList<OpcionBook> bookOptions = new List<OpcionBook>();

        public IList<OpcionBook> State
        {
            get => bookOptions;
            set
            {
                bookOptions.Clear();
                foreach (OpcionBook bookOption in value)
                {
                    bookOptions.Add(bookOption);
                }
            }
        }
    }
}