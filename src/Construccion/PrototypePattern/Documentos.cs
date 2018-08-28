using System.Collections.Generic;

namespace PrototypePattern
{
    public abstract class Documentos
    {
        public IList<Documento> documentos { get; protected set; }
    }
}