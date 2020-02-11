using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.SingletonPattern
{
    class ThreadSafeSingleton
    {
        private static int Counter = 0;
        private static readonly object instancelock = new object();
        private ThreadSafeSingleton()
        {
            Counter++;
            Console.WriteLine("CounterVAlue is:"+Counter);
        }
    }
}
