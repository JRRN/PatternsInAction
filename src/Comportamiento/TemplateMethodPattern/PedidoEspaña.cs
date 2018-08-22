namespace TemplateMethodPattern
{
    public class PedidoEspaña : Pedido
    {
        public override void CalcularIva()
        {
            Iva = ImporteSinIva * 0.21;
        }
    }
}