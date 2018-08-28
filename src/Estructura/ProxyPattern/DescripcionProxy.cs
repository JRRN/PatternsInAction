using System;

namespace ProxyPattern
{
    public class DescripcionProxy : IBook
    {
        protected IBook book = null;
        protected string descripcion = "Mostrar descripción";

        public void CargaDescripcion()
        {
            if (book == null)
            {
                book = new DescripcionProxy();
                book.CargaDescripcion();
            }
            book.CargaDescripcion();
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

        public void Renderiza(string descripcion)
        {
            Console.WriteLine($"Mostrando descripción {descripcion}");
        }

    }
}