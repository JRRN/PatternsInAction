using System.Collections.Generic;

namespace CompositePattern
{
    public  class EditorialCliente : Cliente
    {
        protected List<Cliente> _clientesEditorial = new List<Cliente>();

        public override double CalcularPedido()
        {
            double total = 0.0;

            foreach (Cliente clienteEditorial in _clientesEditorial)
            {
                total = total + clienteEditorial.CalcularPedido();
            }
            return total + _numeroLibros * _costeLibroUnitario;
        }

        public override bool AgregarEditorial(Cliente cliente)
        {
            _clientesEditorial.Add(cliente);
            return true;
        }

    }
}