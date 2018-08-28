using System.Collections.Generic;

namespace PrototypePattern
{
    public class DocumentosCliente : Documentos
    {
        public DocumentosCliente(string informacion)
        {
            documentos = new List<Documento>();
            DocumentosVacios documentosVacios = DocumentosVacios.Instance();
            IList<Documento> documentoVacios = documentosVacios.documentos;

            foreach (Documento docs in documentoVacios)
            {
                Documento copioDocumento = docs.Duplica();
                copioDocumento.Rellena(informacion);
                documentos.Add(copioDocumento);
            }
        }
        public void Visualiza()
        {
            foreach (Documento documento in documentos)
            {
                documento.Visualiza();
            }
        }
        public void Imprime()
        {
            foreach (Documento documento in documentos)
            {
                documento.Visualiza();
            }
        }
    }
}