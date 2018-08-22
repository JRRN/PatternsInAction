using System;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class TorreDeControl
    {
        private bool _pistaLlena;
        private int _numero;
        public void RecibeMensaje(int numero)
        {
            while (_pistaLlena)
            {
                try
                {
                    Task.Delay(2000);
                    _pistaLlena = false;
                }
                catch (Exception e)
                {
                }
            }
            _pistaLlena = true;
            _numero = numero;
        }
        public int EnviaMensaje()
        {
            while (_pistaLlena == false)
            {
                try
                {
                    Task.Delay(2000);
                }
                catch (Exception e)
                {
                }
            }
            _pistaLlena = false;
            return _numero;
        }
    }
}