namespace CompositePattern
{
    public abstract class Cliente
    {
        protected static double _costeLibroUnitario = 4.0;
        protected int _numeroLibros;

        public void AnadirLibro() => _numeroLibros += 1;

        public abstract double CalcularPedido();
        public abstract bool AgregarEditorial(Cliente nombreClienteEditorial);
    }
}
