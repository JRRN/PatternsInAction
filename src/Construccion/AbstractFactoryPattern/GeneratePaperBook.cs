namespace AbstractFactoryPattern
{
    public class GeneratePaperBook
    {
        public PaperBook public class GeneratePaperBook(string titulo, string autor, int añoPublicacion, FormatType formatType)
        {
            return new PaperBook(titulo, autor, añoPublicacion, formatType);
        }
    }
}