namespace ChainOfResponsabilityPattern
{
    public class LibroCoR : BaseLibro
    {
        protected string _libroDescripcion;

        public LibroCoR(string descripcion)
        {
            _libroDescripcion = descripcion;
        }

        protected override string descripcion => _libroDescripcion;
    }
}