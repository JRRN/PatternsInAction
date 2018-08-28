using System;

namespace AbstractFactoryPattern
{
    public class Factory : IFactory
    {
        public Book NewBook(string titulo, string autor, int añoPublicacion, FormatType formatType)
        {
            switch (formatType)
            {
                case FormatType.Media:
                    return new MediaBook(titulo, autor, añoPublicacion, formatType);
                case FormatType.Paper:
                    return new PaperBook(titulo, autor, añoPublicacion, formatType);
                default:
                    throw new ArgumentOutOfRangeException(nameof(formatType), formatType, null);
            }
        }

        public Magazine NewMagazine(string titulo, int añoPublicacion, FormatType formatType)
        {
            switch (formatType)
            {
                case FormatType.Media:
                    return new MediaMagazine(titulo, añoPublicacion, formatType);
                case FormatType.Paper:
                    return new PaperMagazine(titulo, añoPublicacion, formatType);
                default:
                    throw new ArgumentOutOfRangeException(nameof(formatType), formatType, null);
            }
        }
    }
}