namespace VisitorPattern
{
    public abstract class Editorial
    {
        public string Nombre { get; protected set; }
        public string Email { get; protected set; }
        public string Direccion { get; protected set; }

        protected Editorial(string nombre, string email, string direccion)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.Direccion = direccion;
        }

        public abstract bool AgregarEditorialFilial(Editorial filial);

        public abstract void AceptaVisitante(IVisitante visitante);
    }
}
