using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.SingletonPattern
{
    class ThreadSafeSingleton
    {
        private static int Counter = 0;
        private static readonly ThreadSafeSingleton instancelock = new ThreadSafeSingleton();
        public ThreadSafeSingleton()
        {
            Counter++;
            Console.WriteLine("Counter Value is : "+Counter);
        }
    }
}
