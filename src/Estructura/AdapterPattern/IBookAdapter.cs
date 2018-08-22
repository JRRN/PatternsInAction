namespace AdapterPattern
{
    public interface IBookAdapter
    {
        string Contenido { set; }
        void Compone();
        void Imprime();
        void Enviar();
    }
}