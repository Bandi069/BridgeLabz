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

                Console.WriteLine("Press 1 : To Create Account");
                Console.WriteLine("Press 2 : To Print Report");
                Console.WriteLine("Press 3 : To Buy Shares");
                Console.WriteLine("Press 4 : To Show My Account Details");
                Console.WriteLine("Press 5 : To Number Of Shares");
                Console.WriteLine("Press 6 : To Sell Shares");

                ////take choice from user
                Console.WriteLine("Enter Your Choice To Run Operation ");
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

                Console.WriteLine("\nDo You want To Continue the Press 'Yes' Or 'No' ");
                repeat = Console.ReadLine().ToLower();
            }
            while (repeat == "yes");
        }
    }
}
