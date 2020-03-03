// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDetails.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class UserDetils
    {
        /// <summary>
        /// This is string variable account Holder Name
        /// </summary>
        public string accountHolderName;

        /// <summary>
        /// This is double variable  total Amount of account holder.
        /// </summary>
        public double totalAmountAccountHolder;

        /// <summary>
        /// This int variable  total share buy by user
        /// </summary>
        public int noOfShareBuyUser = 0;

        /// <summary>
        /// This is Account Holder Name property
        /// </summary>
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
        /// This is method of Useget input.
        /// </summary>
        public void UseGetInput()
        {
            Console.WriteLine("Enter the UserName of Account Holder");
            accountHolderName = Console.ReadLine();

            Console.WriteLine("Total Amount");
            totalAmountAccountHolder = Convert.ToInt32(Console.ReadLine());
        }
    }
}

