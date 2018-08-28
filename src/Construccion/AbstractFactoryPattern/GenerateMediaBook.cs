namespace AbstractFactoryPattern
{
    public class GenerateMediaBook
    {
        public MediaBook GenerateMediaBook(string titulo, string autor, int añoPublicacion, FormatType formatType)
        {
            return new MediaBook(titulo, autor, añoPublicacion, formatType);
        }
    }
}