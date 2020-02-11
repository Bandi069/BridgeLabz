using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.SingletonPattern
{
    class SingletonOperations
    {
        public void OperationsOfSingleton()
        {
            //// Opeartions of Singleton
            Console.WriteLine("1. Eager Initilalization Operation");
            Console.WriteLine("************************\n");
            Console.WriteLine("Enter a require Oepration to be Perform");
            int OperationNumber = int.Parse(Console.ReadLine());
            switch (OperationNumber)
            {
                case 1:
                    EagerInitialization EagerObj = new EagerInitialization();
                    EagerObj.Eagerinitiliaze();
                    break;
            }
        }
    }
}
