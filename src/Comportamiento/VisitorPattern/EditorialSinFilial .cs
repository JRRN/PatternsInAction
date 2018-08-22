namespace VisitorPattern
{
    public class EditorialSinFilial : Editorial
    {
        public EditorialSinFilial(string nombre, string email, string direccion)
            : base(nombre, email, direccion) { }

        public override bool AgregarEditorialFilial(Editorial filial)
        {
            return false;
        }

        public override void AceptaVisitante(IVisitante visitante)
        {
            visitante.Visita(this);
        }
    }
}