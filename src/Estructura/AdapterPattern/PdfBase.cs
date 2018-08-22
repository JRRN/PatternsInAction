using System;

namespace AdapterPattern
{
    public class PdfBase
    {
        protected string _contenido;

        public void PdfComponeContenido(string contenido)
        {
            _contenido = contenido;
        }

        public void PdfPrevisualizar()
        {
            Console.WriteLine($"Previsualización de Contenido: { _contenido }");
        }

        public void PdfAlmacena()
        {
            Console.WriteLine($"Guardando de Book");
        }

        public void PdfImprimePorPantalla()
        {
            Console.WriteLine($"Imprime por pantall { _contenido }");
        }

        public void PdfEnviar()
        {
            Console.WriteLine($"Enviando link de descarga al cliente");
        }
    }
}
