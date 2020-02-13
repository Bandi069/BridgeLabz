// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using DesignPatternPrograms.SingletonPattern;
using DesignPatternPrograms.FactoryPattern;
using System;


namespace DesignPatternPrograms
{
    class Program
    {
        /// <summary>
        /// Main method for Design Pattern Programs
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //// List of Programs
            Console.WriteLine("1. Singleton Design Pattern");
            Console.WriteLine("2. Factory Design Pattern");
            
            Console.WriteLine("\n**************************");
            Console.WriteLine("Enter a choice for required program to run");
            int Choice = int.Parse(Console.ReadLine());
            switch(Choice)
            {
                //// Case 1 for Singleton Design Pattern
                case 1:
                    SingletonOperations SingtonObj = new SingletonOperations();
                    SingtonObj.OperationsOfSingleton();
                    break;
                case 2:
                    MainFactory FactoryObj = new MainFactory();
                    FactoryObj.FactoryProduction();
                    break;
                    //// Default case for Invalid choice
                default:
                    Console.WriteLine("Entered Invalid Choice...Enter Valid Choice");
                    break;

            }
            
        }
    }
}
