namespace AbstractFactoryPattern
{
    public interface IFactory
    {
        Book NewBook(string titulo, string autor, int añoPublicacion, FormatType formatType);
        Magazine NewMagazine(string titulo, int añoPublicacion, FormatType formatType);
    }
}