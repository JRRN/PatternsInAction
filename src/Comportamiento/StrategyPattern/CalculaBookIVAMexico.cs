using System;

namespace StrategyPattern
{
    public class CalculaBookIvaMexico : IBookCalculaIva
    {
        protected double PrecioFinal;

        public double CalculaIva(double precioBook)
        {
            PrecioFinal = precioBook + precioBook * 0.16;
            return PrecioFinal;
        }

        public void ImprimeResultado()
        {
            Console.WriteLine(PrecioFinal);
        }
    }
}