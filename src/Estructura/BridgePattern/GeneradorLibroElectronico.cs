namespace BridgePattern
{
    public class GeneradorLibroElectronico : GeneradorLibro
    {
        public GeneradorLibroElectronico(IBookBridge book) : base(book) { }

        public override bool ControlTipoLibro(TipoLibroEnum tipoLibro)
        {
            return tipoLibro == TipoLibroEnum.Media;
        }
    }
}