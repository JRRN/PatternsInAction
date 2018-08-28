namespace PrototypePattern
{
    public abstract class Documento
    {
        protected string contenido = "";

        public Documento Duplica()
        {
            var resultado = (Documento)MemberwiseClone();
            return resultado;
        }

        public void Rellena(string informacion)
        {
            contenido = informacion;
        }

        public abstract void Imprime();
        public abstract void Visualiza();
    }
}