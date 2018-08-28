using System;

namespace BuilderPattern
{
    public class DocumentacionHtml : Documentacion
    {
        public override void AgregaDocumento(string documento)
        {
            if (documento.StartsWith("HTML", StringComparison.Ordinal))
            {
                contenido.Add(documento);
            }
        }

        public override void Imprime()
        {
            Console.WriteLine("Documentación HTML");
            foreach (var s in contenido) Console.WriteLine(s);
        }
    }
}