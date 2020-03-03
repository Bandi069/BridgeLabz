// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccountOperatiosn.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
namespace OOPS.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// This is Stock Account Operations Class
    /// </summary>
    class StockAccountOperatiosn
    {
        /// <summary>
        /// This is Atock Account Choice Method
        /// </summary>
        public static void StockAccountChoice()
        {
            //// Creating object for stock Account
            StockAccount stockAccount = new StockAccount();
            string repeat;
            do
            {
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Print the Report");
                Console.WriteLine("3. Buy Shares");
                Console.WriteLine("4. Show My Account Details");
                Console.WriteLine("5. Number Of Shares");
                Console.WriteLine("6. Shares Sell ");

                //// User Choice
                Console.WriteLine("Enter Choice To Run Operation ");
                int Choice = Convert.ToInt32(Console.ReadLine());
                //// Switch Case for Choice (For Different Operations)
                switch (Choice)
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

                Console.WriteLine("\nTo Continue the Press 'Y' Or exit-> 'N' ");
                repeat = Console.ReadLine().ToLower();
            }
            while (repeat == "Y");
        }
    }
}
