namespace CompositePattern
{
    public class ClienteFinal : Cliente
    {
        public override double CalcularPedido()
        {
            return _numeroLibros * _costeLibroUnitario;
        }

        public override bool AgregarEditorial(string nombreClienteEditorial)
        {
            throw new System.NotImplementedException();
        }

        public bool AgregarCliente(Cliente cliente)
        {
            return false;
        }
    }
}