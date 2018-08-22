using System;
using System.Collections.Generic;

namespace CommandPattern
{
    public class AplicarRebaja
    {
        protected IList<BookCommand> _stockLibros = new List<BookCommand>();
        protected long _hoy;
        protected long _tiempoStock;
        protected double _descuento;

        public AplicarRebaja(long tiempoStock, double descuento)
        {
            _hoy = DateTime.Now.Ticks;
            _tiempoStock = tiempoStock;
            _descuento = descuento;
        }

        public void Rebajar(IList<BookCommand> libros)
        {
            _stockLibros.Clear();
            foreach (var libro in libros)
            {
                if (libro.TiempoStock() >= _tiempoStock){
                    _stockLibros.Add(libro);
                }
            }
            foreach (var libroARebajar in _stockLibros)
            {
                libroARebajar.ActualizaPrecio(1.0 - _descuento);
            }
        }
    }
}