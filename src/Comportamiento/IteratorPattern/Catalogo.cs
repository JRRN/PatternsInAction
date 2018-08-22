using System.Collections.Generic;

namespace IteratorPattern
{
    public abstract class Catalogo<TElemento, TIterador>
        where TElemento : Item
        where TIterador : Iterador<TElemento>, new()
    {
        protected IList<TElemento> contenido = new List<TElemento>();

        public TIterador Busqueda(string palabraClaveConsulta)
        {
            TIterador resultado = new TIterador
            {
                contenido = contenido,
                palabraClaveConsulta = palabraClaveConsulta
            };

            return resultado;
        }
    }
}