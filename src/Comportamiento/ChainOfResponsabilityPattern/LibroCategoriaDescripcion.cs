namespace ChainOfResponsabilityPattern
{
    public class LibroCategoriaDescripcion : BaseLibro
    {
        protected string _categoriaDescripcion;
        protected string _categoria;

        public LibroCategoriaDescripcion(string descripcion, string categoria)
        {
            _categoriaDescripcion = descripcion;
            _categoria = categoria;
        }

        protected override string descripcion => _categoriaDescripcion != null ? $"La categoria {_categoria} : {_categoriaDescripcion}" : null;
    }
}