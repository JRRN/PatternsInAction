using System.Collections.Generic;

namespace SingletonPattern
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
            if (_instance == null)
            {
                _instance = new DocumentosVacios();
            }
        }
        public void Incluye(Documento doc)
        {
            documentos.Add(doc);
        }
        public void Excluye(Documento doc)
        {
            documentos.Remove(doc);
        }
    }
}
