using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class PedidoFM
    {
        protected double _importe;

        protected PedidoFM(double importe)
        {
            _importe = importe;
        }
        public abstract bool Valida();
        public abstract void Paga();
    }
}
