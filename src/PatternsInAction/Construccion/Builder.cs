using System;
using BuilderPattern;

namespace PatternsInAction.Construccion
{
    public class Builder
    {
        public static void Show()
        {
            ConstructorDocumentacion constructor;
            Console.WriteLine("Desea generar documentación HTML (1) o PDF (2):");
            string seleccion = Console.ReadLine();
            if (seleccion == "1")
            {
                constructor = new ConstructorDocumentacionHtml();
            }
            else
            {
                constructor = new ConstructorDocumentacionPdf();
            }
            Vendedor vendedor = new Vendedor(constructor);
            Documentacion documentacion = vendedor.Construye("JRRN");
            documentacion.Imprime();
        }
    }
}