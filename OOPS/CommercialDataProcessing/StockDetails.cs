// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StockDetails.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS.CommercialDataProcessing
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class StockDetails
    {
        /// <summary>
        /// This is stock name of company
        /// </summary>
        private string stockName;

        /// <summary>
        /// This variable stored number of share
        /// </summary>
        private int noOfShare;

        /// <summary>
        /// This variable Shareprice 
        /// </summary>
        private double sharePrice;

        /// <summary>
        /// This is the method to get stock input details.
        /// </summary>
        public void StockGetInput()
        {
            Console.WriteLine("Enter Name of Stock ");
            this.stockName = Console.ReadLine();
            Console.WriteLine("Enter Number of Shares of the stock");
            this.noOfShare = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of  Share ");
            this.sharePrice = Convert.ToInt32(Console.ReadLine());
        }
    }
}

