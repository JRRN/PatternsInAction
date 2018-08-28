using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class LibroPedido
    {
        protected IList<OpcionLibro> opcionLibro = new List<OpcionLibro>();
        protected IList<int> precioVenta = new List<int>();

        public void agregaOpcionLibro(TipoLibroEnum tipoLibro, int precio, DeterminaOpcion opcion)
        {
            opcionLibro.Add(DeterminaOpcion.GetOpcionesLibro(tipoLibro));
            precioVenta.Add(precio);
        }

        public void MuestraOpciones()
        {
            var tamaño = opcionLibro.Count;

            for (int indice = 0; indice < tamaño; indice++)
            {
                opcionLibro[indice].VerOpcionesLibro();
                Console.WriteLine();
            }
        }
    }
}