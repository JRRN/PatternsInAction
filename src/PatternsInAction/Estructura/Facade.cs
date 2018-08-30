using System;
using FacadePattern;

namespace PatternsInAction.Estructura
{
    class Facade
    {
        public  static void Show()
        {
            IFacadeService _facade = new FacadeService();

            _facade.GetCatalogo();
            
            _facade.GetBookById(Guid.NewGuid());

            _facade.GetPedidoById(Guid.NewGuid());
        }
    }
}