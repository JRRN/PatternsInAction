using System.Collections.Generic;

namespace FlyweightPattern
{
    public class DeterminaOpcion
    {
        protected IDictionary<TipoLibroEnum, OpcionLibro> opcionesLibro = new Dictionary<TipoLibroEnum, OpcionLibro>();
        public static OpcionLibro GetOpcionesLibro(TipoLibroEnum tipoLibro) => new OpcionLibro(tipoLibro);
    }
}