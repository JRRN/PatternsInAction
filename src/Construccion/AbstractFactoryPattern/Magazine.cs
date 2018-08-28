namespace AbstractFactoryPattern
{
    public abstract class Magazine
    {
        protected string _titulo;
        protected int _añoPublicacion;
        protected FormatType _formatType;

        protected Magazine(string titulo, int añoPublicacion, FormatType formatType)
        {
            _titulo = titulo;
            _añoPublicacion = añoPublicacion;
            _formatType = formatType;
        }
        public abstract void MostrarCaracteristicas();
    }
}