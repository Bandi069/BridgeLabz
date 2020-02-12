using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.SingletonPattern
{
    /// <summary>
    /// Class for Singleton Operations
    /// </summary>
    class SingletonOperations
    {
        /// <summary>
        /// Method for Operations of all singleton design pattern
        /// </summary>
        public void OperationsOfSingleton()
        {
            try
            {
                //// Opeartions List of Singleton
                Console.WriteLine("1. Eager Initilalization singleton Operation");
                Console.WriteLine("2. Thread-Safe Singleton Operation");
                Console.WriteLine("3. Songleton Lazy initialization Opeartion");
                Console.WriteLine("************************\n");
                Console.WriteLine("Enter a require Operation to Perform");
                int OperationNumber = int.Parse(Console.ReadLine());
                switch (OperationNumber)
                {
                    //// Case 1 for Eager initilization of Singleton 
                    case 1:
                        EagerInitialization EagerObj = EagerInitialization.GetSingleton;
                        EagerObj.Message("Hi,This is Eager");
                        break;
                    //// Case 2 for Thread safe singleton 
                    case 2:
                        ThreadSafeSingleton threadSafeObj = ThreadSafeSingleton.GetThreadSingleton;
                        threadSafeObj.Message("Hi,This is Threadsafe Singleton");
                        break;
                    //// Case 3 for Lazy Initialization of Singleton
                    case 3:
                        LazyInitialization LazySingleObj = LazyInitialization.GetSingletonLazy;
                        LazySingleObj.Message("Hi,This is Lazy Singleton Design Pattern");
                        break;
                }
            }
            //// To display the Exception by Message 
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs" + e.Message);
            }
        }

    }
}
