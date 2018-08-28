using System.Collections.Generic;

namespace MementoPattern
{
    public class MementoImplementation : IMemento
    {
        protected IList<OpcionBook> _bookOptions = new List<OpcionBook>();

        public IList<OpcionBook> State
        {
            get => _bookOptions;
            set
            {
                _bookOptions.Clear();
                foreach (OpcionBook bookOption in value)
                {
                    _bookOptions.Add(bookOption);
                }
            }
        }
    }
}