namespace ObserverPattern
{
    public class Book : ObjetoPrincipal
    {
        protected string _descripcion;
        protected string _precio;

        public string Descripcion
        {
            get => _descripcion;
            set { _descripcion = value; this.Actualiza(); }
        }

        public string Precio
        {
            get => _descripcion;
            set { _descripcion = value; this.Actualiza(); }
        }
    }
}