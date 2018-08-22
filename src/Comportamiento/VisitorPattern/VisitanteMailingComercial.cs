using System;

namespace VisitorPattern
{
    public class VisitanteMailingComercial : IVisitante
    {
        public void Visita(EditorialSinFilial editorial)
        {
            Console.WriteLine($"Envía mail a {editorial.Nombre} a {editorial.Email}");
        }
        public void Visita(EditorialMadre editorial)
        {
            Console.WriteLine($"Envía mail a {editorial.Nombre} a {editorial.Email}");
        }
    }
}