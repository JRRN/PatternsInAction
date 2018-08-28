using System;

namespace PrototypePattern
{
    public abstract class DocumentoDigital
    {
        protected string _contenido = String.Empty;
        public DocumentoDigital Duplica()
        {
            var resultado = (DocumentoDigital)MemberwiseClone();
            return resultado;
        }
        public void Rellena(string contenido)
        {
            _contenido = contenido;
        }
        public abstract void Genera();
        public abstract void Visualiza();
    }
}
