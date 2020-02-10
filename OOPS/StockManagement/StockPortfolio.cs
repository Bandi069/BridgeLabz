using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OOPS.StockManagement
{
    class StockPortfolio
    {
         string FilePath = @"C:\Users\Bridge Labs\source\repos\OOPS\OOPS\StockManagement\JsonFile.json";
        public void Stock()
        {
            try
            {
                PropertyClass PropertyObj = new PropertyClass();
                var readjson = File.ReadAllText(FilePath);
                List<StockPortfolio> stockList
                    = JsonConvert.DeserializeObject<List<StockPortfolio>>(readjson);
                double totalSharePrice = 0.0;
              
                foreach(var Property in stockList)
                {
                    totalSharePrice = PropertyObj.SharePrice * PropertyObj.NumberOfShare;
                    Console.WriteLine("Name Of Stock : " + PropertyObj.NameOfShare);
                    Console.WriteLine("Total Share : " + PropertyObj.NumberOfShare);
                    Console.WriteLine("Each Share Price :" + PropertyObj.SharePrice);
                    Console.WriteLine("Total Share Price: " + totalSharePrice);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

