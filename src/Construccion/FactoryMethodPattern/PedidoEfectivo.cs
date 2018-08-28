using System;

namespace FactoryMethodPattern
{
    public class PedidoEfectivo  : PedidoFM
    {
        public PedidoEfectivo(double importe) : base(importe) { }
        public override void Paga()
        {
            Console.WriteLine($"Método de Pago Efectivo, importe: { _importe }");
        }
        public override bool Valida() { return true; }
    }
}