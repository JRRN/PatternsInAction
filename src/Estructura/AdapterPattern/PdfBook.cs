namespace AdapterPattern
{
    public class PdfBook : IBookAdapter
    {
        protected PdfBase _pdfBase = new PdfBase();

        public string Contenido
        {
            set => _pdfBase.PdfComponeContenido(value);
        }

        public void Compone()
        {
            _pdfBase.PdfPrevisualizar();
            _pdfBase.PdfAlmacena();
        }

        public void Imprime()
        {
            _pdfBase.PdfImprimePorPantalla();
        }

        public void Enviar()
        {
            _pdfBase.PdfEnviar();
        }
    
        
    }
}