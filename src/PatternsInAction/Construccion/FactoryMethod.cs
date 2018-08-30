using FactoryMethodPattern;

namespace PatternsInAction.Construccion
{
    public class FactoryMethod
    {
        public static void Show()
        {
            PedidoTargeta pedidoEfectivo = new PedidoTargeta(100);
            if (pedidoEfectivo.Valida()) { pedidoEfectivo.Paga();}
            
            PedidoTargeta pedidoTargetaNoValido = new PedidoTargeta(1000);
            if (pedidoTargetaNoValido.Valida()) { pedidoTargetaNoValido.Paga(); }

            PedidoTargeta pedidoTargetaValido = new PedidoTargeta(50);
            if (pedidoTargetaValido.Valida()) { pedidoTargetaValido.Paga(); }
        }
    }
}