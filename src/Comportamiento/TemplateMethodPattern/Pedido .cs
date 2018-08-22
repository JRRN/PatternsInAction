using System;

namespace TemplateMethodPattern
{
    public abstract class Pedido
    {
        protected double ImporteSinIva;
        protected double Iva;
        protected double ImporteTotal;

        public abstract void CalcularIva();

        public void CalculaPrecioTotal()
        {
            CalcularIva();
            ImporteTotal = ImporteSinIva + Iva;
        }

        public void SetImporteSinIva(double importeSinIva)
        {
            ImporteSinIva = importeSinIva;
        }

        public void Imprime()
        {
            Console.WriteLine("Pedido");
            Console.WriteLine($"Importe Sin IVA {ImporteSinIva} , IVA {Iva}");
            Console.WriteLine($"Importe Total {ImporteTotal}");
        }
    }
}
