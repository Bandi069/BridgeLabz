// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Array2D.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Oops.InventaoryManagement
{
    /// <summary>
    /// Inventorty Data Class for Various Operations of Inventory Management
    /// </summary>
    class InventoryData
    {
        /// <summary>
        /// Method for the Operations of Inventory Management
        /// </summary>
        public void Inventoryoperation()
        {
            //// Creating Object for Inventory Mangament Class
            InventoryManagement InventObject = new InventoryManagement();
            try
            { //// List of Operations
                Console.WriteLine("1. Display the Details of File");
                Console.WriteLine("2. Adding a New Item to the file");
                Console.WriteLine("3. Updating Item in the file");
                Console.WriteLine("4. Deleting Item in the file");
                Console.WriteLine("*******************************");
                Console.WriteLine("\nEnter a Choice for Opeartion of Inventory Management");
                int choice = int.Parse(Console.ReadLine());
                ///// Switch case for Calling the different methods
                //// By giving the Choice user Input
                switch (choice)
                {
                    //// For get the user details from Json File
                    case 1:
                        InventObject.GetDetails();
                        break;
                    //// Calling AddItem method to add the item to Json File
                    case 2:
                        InventObject.AddItem();
                        break;
                        //// Calling UpdateFile method to update the Json File
                    case 3:
                        InventObject.UpdateFile();
                        break;
                        //// Calling Method to Delete the item from the Json File
                    case 4:
                        InventObject.DeleteItem();
                        break;
                        //// Default Case for invalid user inputs 
                    default:
                        Console.WriteLine("Entered Invalid Choice...Enter Valid Choice");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurs :" + e.Message);
            }
        }
    }
}
