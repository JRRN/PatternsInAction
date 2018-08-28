namespace BridgePattern
{
    public class GeneradorLibroPapel : GeneradorLibro
    {
        public GeneradorLibroPapel(IBookBridge book) : base(book) { }

        public override bool ControlTipoLibro(TipoLibroEnum tipoLibro)
        {
            return tipoLibro == TipoLibroEnum.Paper;
        }
    }
}