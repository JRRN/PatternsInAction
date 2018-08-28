namespace BridgePattern
{
    public abstract class GeneradorLibro
    {
        public TipoLibroEnum _tipoLibroEnum;
        public IBookBridge _book;

        protected GeneradorLibro(IBookBridge book)
        {
            _book = book;
        }

        public void Genera()
        {
            _book.GenerarLibro();
        }

        public TipoLibroEnum TipoDeLibro()
        {
            return _book.TipoDeLibro();
        }

        public abstract bool ControlTipoLibro(TipoLibroEnum tipoLibro);
    }
}