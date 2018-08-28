namespace DecoratorPattern
{
    public abstract class Decorador : ICatalogo
    {
        protected ICatalogo _catalogo;

        protected Decorador(ICatalogo catalogo)
        {
            _catalogo = catalogo;
        }

        public virtual void VerCatalogo()
        {
            VerDatosLibro();
        }

        public void VerDatosLibro()
        {
            _catalogo.VerDatosLibro();
        }
    }
}