using System;

namespace FactoryMethodPattern
{
    public class PedidoTargeta : PedidoFM
    {
        public PedidoTargeta(double importe) : base(importe) { }
        public override void Paga()
        {
            Console.WriteLine($"Método de Pago Targeta, importe: {_importe}");
        }
        public override bool Valida() => _importe >= 0.0 && _importe <= 500.0;
    }
}