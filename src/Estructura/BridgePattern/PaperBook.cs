using System;

namespace BridgePattern
{
    public class PaperBook : IBookBridge
    {
        public void GenerarLibro()
        {
            Console.WriteLine("Libro de Papel");
        }

        public TipoLibroEnum TipoDeLibro()
        {
            return TipoLibroEnum.Paper;
        }
    }
}