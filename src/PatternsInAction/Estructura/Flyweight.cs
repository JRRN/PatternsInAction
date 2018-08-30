using FlyweightPattern;

namespace PatternsInAction.Estructura
{
    class Flyweight
    {
        public  static void Show()
        {
            DeterminaOpcion opcion = new DeterminaOpcion();
            LibroPedido libroPedido = new LibroPedido();

            libroPedido.AgregaOpcionLibro(TipoLibroEnum.Anillas, 10, opcion);
            libroPedido.AgregaOpcionLibro(TipoLibroEnum.Encolado, 30, opcion);

            libroPedido.MuestraOpciones();
        }
    }
}