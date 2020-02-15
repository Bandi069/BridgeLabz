// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using DesignPatternPrograms.SingletonPattern;
using DesignPatternPrograms.FactoryPattern;
//using DesignPatternPrograms.PrototypeDesignpattern;
using DesignPatternPrograms.AdapterDesignPattern;
using DesignPatternPrograms.StructuralDesignPaytterns.FacadeProductDesign;
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
            Console.WriteLine("3. Proto type Design Pattern");
            Console.WriteLine("4. Adapter Design Pattern");
            Console.WriteLine("5. Facade Design Pattern");
            
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
                    //// Case 2 for Factory Design Pattern Program
                case 2:
                 MainFactory FactoryObj = new MainFactory();
                    FactoryObj.FactoryProduction();
                    break;
                    //// ProtoType Design Pattern
                case 3:
                   ProtoTypeOperation ProtoObj = new ProtoTypeOperation();
                    ProtoObj.CloneOperation();
                    break;
                    //// Adapter Design Pattern 
                case 4:
                    Adaptee Adaptrobj = new Adaptee();
                    Adaptrobj.GetList();
                    break;
                    //// This is Case for Facade Design Pattern 
                case 5:
                    FacadeAddressBook FacadeObj = new FacadeAddressBook();
                    FacadeObj.FirstName();
                    break;
                    //// Default case for Invalid choice
                default:
                    Console.WriteLine("Entered Invalid Choice...Enter Valid Choice");
                    break;

            }
            
        }
    }
}
