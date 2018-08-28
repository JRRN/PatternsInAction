using System;

namespace ProxyPattern
{
    public class DescripcionProxy : IBook
    {
        protected Datos book = null;
        protected string descripcion = "Desccripción Simple";

        public void CargaDescripcion()
        {
            if (book == null)
            {
                book = new Datos();
                book.CargaDescripcion();
            }
            else { book.CargaDescripcion(); }

        }

        public void Renderiza()
        {
            if (book != null)
            {
                book.Renderiza();
            }
            else
            {
                Renderiza(descripcion);
            }
        }

        public void Renderiza(string descripcion) => Console.WriteLine($"{descripcion}");
    }
}