using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OOPS.StockManagement
{
    class StockPortfolio
    {
        public string FilePath = @"C:\Users\Bridge Labs\source\repos\OOPS\OOPS\StockManagement\JsonFile.json";
        public void Stock()
        {

            var readjson = File.ReadAllText(FilePath);
            List<StockPortfolio> stockList = JsonConvert.DeserializeObject<List<StockPortfolio>>(readjson);
            double totalSharePrice = 0.0;
            /* foreach (StockReport objStock in stockList)
             {
                 totalSharePrice = objStock.SharePrice * objStock.numberOfShare;
                 Console.WriteLine("Name Of Stock : " + objStock.nameOfShare);
                 Console.WriteLine("Total Share : " + objStock.numberOfShare);
                 Console.WriteLine("Each Share Price " + objStock.sharePrice);
                 Console.WriteLine("Total Share Price of Stock " + totalSharePrice);
             }*/
            /* foreach(var stocklist in stockList)
             {
                 totalSharePrice=totalSharePrice*

             }
         }*/
        }
    }
}
