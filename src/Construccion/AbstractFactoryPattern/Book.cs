namespace AbstractFactoryPattern
{
    public abstract class Book
    {
        protected string titulo;
        protected string autor;
        protected int añoPublicacion;
        protected FormatType formatType;
        public Book(string titulo, string autor, int añoPublicacion, FormatType formatType)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.añoPublicacion = añoPublicacion;
            this.formatType = formatType;
        }

        public abstract void mostrarCaracteristicas();
    }
}