namespace TemplateMethodPattern
{
    public class PedidoMexico : Pedido
    {
        public override void CalcularIva()
        {
            Iva = ImporteSinIva * 0.16;
        }
    }
}