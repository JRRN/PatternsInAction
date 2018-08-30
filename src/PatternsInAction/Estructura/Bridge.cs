using System;
using BridgePattern;

namespace PatternsInAction.Estructura
{
    class Bridge
    {
        public  static void Show()
        {
            GeneradorLibroElectronico libroElectronico = new GeneradorLibroElectronico(new MediaBook());

            Console.WriteLine(libroElectronico._tipoLibroEnum);
            if (libroElectronico.TipoDeLibro() == TipoLibroEnum.Media)
            {
                libroElectronico.Genera();
            }

            GeneradorLibroPapel libroPapel = new GeneradorLibroPapel(new PaperBook());

            Console.WriteLine(libroPapel._tipoLibroEnum);
            if (libroPapel.TipoDeLibro() == TipoLibroEnum.Paper)
            {
                libroPapel.Genera();
            }
        }
    }
}