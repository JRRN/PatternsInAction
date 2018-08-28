using System;

namespace BridgePattern
{
    public class MediaBook : IBookBridge
    {
        public void GenerarLibro()
        {
            Console.WriteLine("Libro Electronico");
        }

        public TipoLibroEnum TipoDeLibro()
        {
            return TipoLibroEnum.Media;
        }

    }
}