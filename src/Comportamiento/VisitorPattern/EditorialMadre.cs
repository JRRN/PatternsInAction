using System.Collections.Generic;

namespace VisitorPattern
{
    public class EditorialMadre : Editorial
    {
        protected IList<Editorial> EditorialesFiliales = new List<Editorial>();

        public EditorialMadre(string nombre, string email, string direccion)
            : base(nombre, email, direccion) { }

        public override bool AgregarEditorialFilial(Editorial filial)
        {
            EditorialesFiliales.Add(filial);
            return true;
        }

        public override void AceptaVisitante(IVisitante visitante)
        {
            visitante.Visita(this);
            foreach (Editorial editorialFilial in EditorialesFiliales)
            {
                editorialFilial.AceptaVisitante(visitante);
            }
        }
    }
}