using System;

namespace MediatorPattern
{
    public class Productor
    {
        private TorreDeControl _torreControl;
        private int _id;
        private static int num = 1;
        public Productor(TorreDeControl torreControl)
        {
            _torreControl = torreControl;
            _id = num++;
        }
        public void Run()
        {
            int num;
            while (true)
            {
                num = new Random().Next(100, 999);
                _torreControl.RecibeMensaje(num);
                Console.WriteLine($"Productor {_id}");
            }
        }
    }
}