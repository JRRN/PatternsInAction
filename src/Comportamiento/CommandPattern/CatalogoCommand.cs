using System.Collections.Generic;

namespace CommandPattern
{
    public class CatalogoCommand
    {
        protected IList<BookCommand> _stockLibros = new List<BookCommand>();
        protected IList<AplicarRebaja> commands = new List<AplicarRebaja>();

        public void commandRebaja(AplicarRebaja aplicarRebaja)
        {
            commands.Insert(0, aplicarRebaja);
            aplicarRebaja.Rebajar(_stockLibros);
        }

        public void CommandAnulaRebaja(int commandNum)
        {
            //commands[commandNum].Anular();
        }

        public void RestablecerSolicitudRebaja(int commandNum)
        {
            //commands[commandNum].Restablecer();
        }

        public void Agrega(BookCommand libro)
        {
            _stockLibros.Add(libro);
        }

        public void Visualiza()
        {
            foreach (BookCommand libro in _stockLibros)
            {
                libro.Ver();
            }
        }
    }
}