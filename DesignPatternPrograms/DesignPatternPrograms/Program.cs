using DesignPatternPrograms.SingletonPattern;
using System;


namespace DesignPatternPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //// List of Programs
            Console.WriteLine("1. Singleton Design Pattern");
            
            Console.WriteLine("\n**************************");
            Console.WriteLine("Enter a choice for required program to run");
            int Choice = int.Parse(Console.ReadLine());
            switch(Choice)
            {
                case 1:
                    SingletonOperations SingtonObj = new SingletonOperations();
                    SingtonObj.OperationsOfSingleton();
                    break;
                default:
                    Console.WriteLine("Entered Invalid Choice...Enter Valid Choice");
                    break;

            }
            
        }
    }
}
