using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.SingletonPattern
{
    class SingletonOperations
    {
        public void OperationsOfSingleton()
        {
            try
            {

                //// Opeartions List of Singleton
                Console.WriteLine("1. Eager Initilalization singleton Operation");
                Console.WriteLine("2. Thread-Safe Singleton Operation");
                Console.WriteLine("3. Songleton Lazy initialization OOpeartion");
                Console.WriteLine("************************\n");
                Console.WriteLine("Enter a require Oepration to be Perform");
                int OperationNumber = int.Parse(Console.ReadLine());
                switch (OperationNumber)
                {
                    case 1:
                        EagerInitialization EagerObj = EagerInitialization.GetSingleton;
                        EagerObj.Message("Hi,This is Eager");
                        break;
                    case 2:
                        ThreadSafeSingleton threadSafeObj = ThreadSafeSingleton.GetThreadSingleton;
                        threadSafeObj.Message("Hi,This is Threadsafe Singleton");
                        break;
                    case 3:
                        LazyInitialization LazySingleObj = LazyInitialization.GetSingletonLazy;
                        LazySingleObj.Message("Hi,This is Lazy Singleton Design Pattern");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs" + e.Message);
            }
        }
      
    }
}
