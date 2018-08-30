using ProxyPattern;

namespace PatternsInAction.Estructura
{
    class Proxy
    {
        public  static void Show()
        {
            IBook book = new DescripcionProxy();

            book.Renderiza();
            book.CargaDescripcion();
        }
    }
}