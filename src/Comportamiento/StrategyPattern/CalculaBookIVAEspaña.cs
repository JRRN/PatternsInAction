using System;

namespace StrategyPattern
{
    public class CalculaBookIvaEspaña : IBookCalculaIva
    {
        protected double PrecioFinal;

        public double CalculaIva(double precioBook)
        {
            PrecioFinal = precioBook + precioBook * 0.21;
            return PrecioFinal;
        }

        public void ImprimeResultado()
        {
            Console.WriteLine(PrecioFinal);
        }
    }
}
