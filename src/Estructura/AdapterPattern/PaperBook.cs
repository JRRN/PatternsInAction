using System;

namespace AdapterPattern
{
    public class PaperBook : IBookAdapter
    {

        protected string _contenido;

        public string Contenido
        {
            protected get { return _contenido; }
            set { _contenido = value; }
        }

        public void Compone()
        {
            var content = Contenido;
        }

        public void Imprime()
        {
            Console.WriteLine($"Mandando a imprimir Contenido { _contenido }");
        }

        public void Enviar()
        {
            Console.WriteLine($"Enviar al cliente");
        }
    }
}