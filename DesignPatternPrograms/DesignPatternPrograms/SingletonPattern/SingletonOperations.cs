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
                        /* EagerInitialization EagerObj=EagerInitialization.GetSingleton();
                         EagerObj.Message();*/

                        break;
                    case 2:
                        //  ThreadSafeSingleton threadSafeObj = ThreadSafeSingleton();
                        //threadSafeObj.ThreadSafeSingleton();

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
