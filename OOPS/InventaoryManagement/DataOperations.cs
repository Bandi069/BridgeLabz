using System;
using System.Collections.Generic;
using System.Text;
using OOPS.InventaoryManagement;

namespace Oops.InventaoryManagement
{
    class DataOperations
    {
        public static void DataOperation()
        {
            string repeat;

            do
            {
                InventoryManagement invetoryManagement = new InventoryManagement();
                Console.WriteLine("Perform An Opearation on Inventory Data Management");
                Console.WriteLine("Press 1 : Inventory Update File");
                Console.WriteLine("Press 2 : Delete File");
                Console.WriteLine("Press 3 : Inventory Reports");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        invetoryManagement.UpdateFile();
                        break;
                    case 2:
                        invetoryManagement.DeleteItem();
                        break;
                    case 3:
                        InventoryReport.InventoryManagementReport();
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Yes' Or 'No' ");
                repeat = Console.ReadLine().ToLower();
            }
            while (repeat == "yes");
        }
    }

}
