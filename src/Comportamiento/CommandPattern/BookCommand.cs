using System;

namespace CommandPattern
{
    public class BookCommand
    {
        protected string _nombre;
        protected DateTime _fechaEntradaStock;
        protected double _precioVenta;

        public BookCommand(string nombre, DateTime fechaEntradaStock, double precioVenta)
        {
            _nombre = nombre;
            _fechaEntradaStock = fechaEntradaStock;
            _precioVenta = precioVenta;
        }

        public long TiempoStock()
        {
            return (DateTime.Now - _fechaEntradaStock).Ticks;
        }

        public void ActualizaPrecio(double descuento)
        {
            _precioVenta = 0.01 * Math.Round(descuento) * _precioVenta * 100;
        }

        public void Ver()
        {
            Console.WriteLine($"{_nombre} tiene un precio {_precioVenta} entrada {_fechaEntradaStock}");
        }
    }
}
