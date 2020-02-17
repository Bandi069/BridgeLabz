using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.StockManagement
{
    class StockReport
    {
        public int NameOfShare { get;  set; }
        public string SharePrice { get; set; }
        public string NumberOfShare { get;  set; }

        public void InputStock()
        {
            PropertyClass PropertyObj = new PropertyClass();
            try
            {
                Console.WriteLine("Enter a Name of the Share");
                PropertyObj.NameOfShare = Console.ReadLine();
                Console.WriteLine("Enter Enter a Number of Share");
                PropertyObj.NumberOfShare = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Share Price ");
                PropertyObj.SharePrice = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurs" + e.Message);
            }

        }
        public  void MethodsCalling()
        {
            StockPortfolio Stockobj = new StockPortfolio();
            Stockobj.Stock();
            Stockobj.AddStock();

        }
    }
}
