using VisitorPattern;

namespace PatternsInAction.Comportamiento
{
    public class Visitor
    {
        public static void Show()
        {
            Editorial editorial1 = new EditorialSinFilial("empresa1", "mail@empresa1.com", "Calle Empresa 1");
            Editorial editorial2 = new EditorialSinFilial("empresa2", "mail@empresa2.com", "Calle Empresa 2");

            Editorial grupoEditorial =
                new EditorialMadre("grupoEditorial1", "mail@grupoEditorial1.com", "Calle Grupo Editorial1");

            grupoEditorial.AgregarEditorialFilial(editorial1);
            grupoEditorial.AgregarEditorialFilial(editorial2);

            Editorial editorial3 = new EditorialSinFilial("empresa3", "mail@empresa3.com", "Calle Empresa 3");

            Editorial grupoEditorial2 = new EditorialMadre("grupoEditorial2", "mail@grupoEditorial2.com", "Calle Grupo Editorial2");

            grupoEditorial2.AgregarEditorialFilial(grupoEditorial);
            grupoEditorial2.AgregarEditorialFilial(editorial3);

            grupoEditorial2.AceptaVisitante(new VisitanteMailingComercial());

        }
    }
}