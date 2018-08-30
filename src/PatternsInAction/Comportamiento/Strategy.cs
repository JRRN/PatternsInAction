using StrategyPattern;

namespace PatternsInAction.Comportamiento
{
    class Strategy
    {
        public  static void Show()
        {
            IBookCalculaIva _calculaIvaEsp = new CalculaBookIvaEspaña();
            IBookCalculaIva _calculaIvaMex = new CalculaBookIvaMexico();

            _calculaIvaEsp.CalculaIva(new CalculaBookIvaEspaña().CalculaIva(10));
            _calculaIvaEsp.ImprimeResultado();

            _calculaIvaMex.CalculaIva(new CalculaBookIvaMexico().CalculaIva(10));
            _calculaIvaMex.ImprimeResultado();
        }
    }
}