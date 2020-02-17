using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.CommercialDataProcessing
{
    class StockDetails
    {
        /// <summary>
        /// this is stock name of company
        /// </summary>
        private string stockName;

        /// <summary>
        /// this variable stored number of share
        /// </summary>
        private int noOfShare;

        /// <summary>
        /// this variable stored price of share.
        /// </summary>
        private double sharePrice;

        /// <summary>
        /// this method get stock input details.
        /// </summary>
        public void StockGetInput()
        {
            Console.WriteLine("Enter Name of Share/Stock ");
            this.stockName = Console.ReadLine();
            Console.WriteLine("Enter Number of Share ");
            this.noOfShare = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price of Per Share ");
            this.sharePrice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
}
