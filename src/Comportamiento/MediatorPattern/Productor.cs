using System;
using System.Threading;

namespace MediatorPattern
{
    public class Productor
    {
        private bool slotFull = false;
        private int number;

        public void Run(int num)
        {
            while (slotFull == true) {
                try {
                    Thread.Sleep(1000);
                }
                catch (Exception e ) {
                    Thread.ResetAbort();
                }
            }
            slotFull = true;
            number = num;
            notifyAll();
        }
    }
}