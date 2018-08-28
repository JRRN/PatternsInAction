namespace BridgePattern
{
    public interface IBookBridge
    {
        void GenerarLibro();

        TipoLibroEnum TipoDeLibro();
    }
}