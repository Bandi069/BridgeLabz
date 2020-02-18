using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.CommercialDataProcessing
{
    class UserDetils
    {
        public string accountHolderName;

        /// <summary>
        /// this variable hold the total balance of account holder.
        /// </summary>
        public double totalAmountAccountHolder;

        /// <summary>
        /// this variable hold the total share buy by user and initially it is zero.
        /// </summary>
        public int noOfShareBuyUser = 0;

        /// <summary>
        /// this method take all user detail which required to create account.
        /// </summary>
        /// <value>
        /// The name of the account holder.
        /// </value>
        public string AccountHolderName
        {
            get
            {
                return accountHolderName;
            }
            set
            {
                accountHolderName = value;
            }
        }

        /// <summary>
        /// Uses the get input.
        /// </summary>
        public void UseGetInput()
        {
            Console.WriteLine("Enter Account Holder UserName");
            accountHolderName = Console.ReadLine();

            Console.WriteLine("How Many Doller Do You Have (Total Amount)");
            totalAmountAccountHolder = Convert.ToInt32(Console.ReadLine());
        }
    }
}

