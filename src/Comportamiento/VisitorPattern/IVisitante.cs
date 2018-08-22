namespace VisitorPattern
{
    public interface IVisitante
    {
        void Visita(EditorialSinFilial editorialSinFilial);
        void Visita(EditorialMadre editorialMadre);
    }
}