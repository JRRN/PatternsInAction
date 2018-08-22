using System;

namespace MediatorPattern
{
    public class Consumidor
    {
        private TorreDeControl _torreControl;
        private int _id;
        private static int num = 1;
        public Consumidor(TorreDeControl torreControl)
        {
            _torreControl = torreControl;
            num++;
            _id = num;
        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine($"Consumidor {_id} {_torreControl.EnviaMensaje()}");
            }
        }
    }
}
