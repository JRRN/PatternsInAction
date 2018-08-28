using System;

namespace BuilderPattern
{
    public class DocumentacionPdf : Documentacion
    {
        public override void AgregaDocumento(string documento)
        {
            if (documento.StartsWith("PDF", StringComparison.Ordinal))
            {
                contenido.Add(documento);
            }
        }

        public override void Imprime()
        {
            Console.WriteLine("Documentación PDF");
            foreach (string s in contenido)
            {
                Console.WriteLine(s);
            }
        }
    }
}