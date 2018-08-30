using TemplateMethodPattern;

namespace PatternsInAction.Comportamiento
{
    public class TemplateMethod
    {
        public static void Show()
        {
            Pedido pedidoEspaña = new PedidoEspaña();
            pedidoEspaña.SetImporteSinIva(1000);
            pedidoEspaña.CalcularIva();
            pedidoEspaña.CalculaPrecioTotal();
            pedidoEspaña.Imprime();

            Pedido pedidoMexico = new PedidoMexico();
            pedidoMexico.SetImporteSinIva(1000);
            pedidoMexico.CalcularIva();
            pedidoMexico.CalculaPrecioTotal();
            pedidoMexico.Imprime();
        }
    }
}