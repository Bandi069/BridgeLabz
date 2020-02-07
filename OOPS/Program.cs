// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Array2D.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using OOPS.AddressBook;
using System;
using Oops.InventaoryManagement;

namespace OOPS
{
    /// <summary>
    /// Main Class for Oops Programs
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main Method
        /// </summary>
        /// <param name="args"></param>
       static void Main(string[] args)
        {
            Console.WriteLine("1.Address Book");
            Console.WriteLine("2.Inventory Management");
            Console.WriteLine("Enter a number to run the required program");
            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    AddressBookOperations operationObj = new AddressBookOperations();
                    operationObj.AddressOperations();
                  
                    break;
                    case 2:
                    InventoryData inventoryobj = new InventoryData();
                    inventoryobj.Inventoryoperation();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }

        }
    }
}
