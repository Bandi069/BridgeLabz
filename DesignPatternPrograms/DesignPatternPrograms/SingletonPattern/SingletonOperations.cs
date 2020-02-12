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
                Console.WriteLine("************************\n");
                Console.WriteLine("Enter a require Oepration to be Perform");
                int OperationNumber = int.Parse(Console.ReadLine());
                switch (OperationNumber)
                {
                    case 1:
                        EagerInitialization EagerObj = new EagerInitialization();
                        EagerObj.Message("Hi,This is Eager");
                        

                        break;
                    case 2:
                         ThreadSafeSingleton threadSafeObj = new ThreadSafeSingleton();
                        threadSafeObj.Message("Hi,This is Threadsafe Singleton");

                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs" + e.Message);
            }
        }
        public static void EagerSingleton()
        {
            EagerInitialization singletonObject = EagerInitialization.GetSingleton;
            singletonObject.Message("Message from Eager Singletone");
        }

    }
}
