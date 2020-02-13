using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.FactoryPattern
{
    class MainFactory
    {
        public void FactoryProduction()
        {
            Console.WriteLine("Enter a Choice to get the Details");
            Console.WriteLine("1.PC\n2.Laptop\n3.Server");
            int Choice = int.Parse(Console.ReadLine());
            switch(Choice)
            {
                case 1:
                    break;
                default:
                    Console.WriteLine("Entered Invalid Choice...Enter a Valid Choice");
                    break;
            }
        }
    }
}
