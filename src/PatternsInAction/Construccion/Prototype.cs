using PrototypePattern;

namespace PatternsInAction.Construccion
{
    public class Prototype
    {
        public static void Show()
        {
            DocumentosVacios documentosVacios = DocumentosVacios.Instance();
            documentosVacios.Incluye(new PedidoPrototype());
            documentosVacios.Incluye(new FacturaPrototype());
            documentosVacios.Incluye(new LibroDigital());
            DocumentosCliente documentoCliente = new DocumentosCliente("Un usuario");
            DocumentosCliente documentoCliente2 = new DocumentosCliente("Otro Usuario");
            documentoCliente.Visualiza();
            documentoCliente2.Visualiza();
        }
    }
}