using System.Collections.Generic;

namespace IteratorPattern
{
    public abstract class Iterador<TItem> where TItem : Item
    {
        public string palabraClaveConsulta { protected get; set; }
        protected int indice;
        public IList<TItem> contenido { protected get; set; }

        public void Inicio()
        {
            indice = 0;
            int length = contenido.Count;
            while (indice < length && !contenido[indice].PalabraClaveValida(palabraClaveConsulta)) {
                indice++;
            }
        }

        public void Siguiente()
        {
            int length = contenido.Count;
            indice++;
            while (indice < length && !contenido[indice].PalabraClaveValida(palabraClaveConsulta)) {
                indice++;
            }
        }

        public TItem item() => indice < contenido.Count ? contenido[indice] : null;
    }
}