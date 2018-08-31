namespace ChainOfResponsabilityPattern
{
    public class LibroDescripcion : BaseLibro
    {
        protected string _libroDescripcion;
        protected string _libro;

        public LibroDescripcion(string descripcion, string libro)
        {
            _libroDescripcion = descripcion;
            _libro = libro;
        }

        protected override string descripcion => _libroDescripcion != null 
                                                  ? $@"El libro {_libro} 
                                                  : {_libroDescripcion}" : null;
    }
}