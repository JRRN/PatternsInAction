using System.Collections.Generic;

namespace PrototypePattern
{
    public class DocumentosVacios : Documentos
    {
        public static DocumentosVacios _instance = null;
        private DocumentosVacios()
        {
            documentos = new List<Documento>();
        }
        public static DocumentosVacios Instance()
        {
            return _instance ?? (_instance = new DocumentosVacios());
        }
        public void Incluye(Documento doc) { documentos.Add(doc); }
        public void Excluye(Documento doc) { documentos.Remove(doc); }
    }
}