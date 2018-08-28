namespace CompositePattern
{
    public class ClienteFinal : Cliente
    {
        public override bool AgregarEditorial(Cliente filial) => false;
        public override double CalcularPedido() => _numeroLibros * _costeLibroUnitario;
    }
}