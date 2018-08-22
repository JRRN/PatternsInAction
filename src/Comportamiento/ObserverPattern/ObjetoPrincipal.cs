using System.Collections.Generic;

namespace ObserverPattern
{
    public abstract class ObjetoPrincipal
    {
        protected IList<IObserver> observadores = new List<IObserver>();

        public void Agrega(IObserver observador)
        {
            observadores.Add(observador);
        }

        public void Quita(IObserver observador)
        {
            observadores.Remove(observador);
        }

        public void Actualiza()
        {
            foreach (var observador in observadores)
            {
                observador.Actualiza();
            }
        }
    }
}
