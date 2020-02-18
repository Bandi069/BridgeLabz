using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.CommercialDataProcessing
{
    class StockAccountOperatiosn
    {
        public static void StockAccountChoice()
        {
            StockAccount stockAccount = new StockAccount();
            string repeat;
            do
            {
                ////here print list of operation which is goining to perform

                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Print Report");
                Console.WriteLine("3. Buy Shares");
                Console.WriteLine("4. Show My Account Details");
                Console.WriteLine("5. Number Of Shares");
                Console.WriteLine("6. Sell Shares");

                ////take choice from user
                Console.WriteLine("Enter Choice To Run Operation ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        stockAccount.StockAcountCreate();
                        break;
                    case 2:
                        stockAccount.PrintReport();
                        break;
                    case 3:
                        stockAccount.Buy();
                        break;
                    case 4:
                        stockAccount.ShowMyAccount();
                        break;
                    case 5:
                        Console.WriteLine(stockAccount.ValueOf());
                        break;
                    case 6:
                        stockAccount.Sell();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("\nTo Continue the Press 'Yes' Or  To exit Press 'No' ");
                repeat = Console.ReadLine().ToLower();
            }
            while (repeat == "yes");
        }
    }
}
