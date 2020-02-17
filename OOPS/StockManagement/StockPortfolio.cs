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
            System.Collections.IList list = stockList;
            for (int i = 0; i < list.Count; i++)
            {
                StockReport objStock = (StockReport)list[i];
                //totalSharePrice = objStock.SharePrice * objStock.NumberOfShare;
                Console.WriteLine("Name Of Stock : " + objStock.NameOfShare);
                Console.WriteLine("Total Share : " + objStock.NumberOfShare);
                Console.WriteLine("One Share Price " + objStock.SharePrice);
                Console.WriteLine("Total Share Price of Stock " + totalSharePrice);
            }

            Console.WriteLine("Share Investing");
            string userStockName = Console.ReadLine();
            System.Collections.IList list1 = stockList;
            for (int i = 0; i < list1.Count; i++)
            {
                StockReport objStock1 = (StockReport)list1[i];
                try
                {
                    if (userStockName.Equals(objStock1.NameOfShare))
                    {
                        Console.WriteLine("No of Shares to Buy");
                        int userShare = Convert.ToInt32(Console.ReadLine());
                        double TotalSharePrice = userShare * objStock1.SharePrice;

                        int availableShare = objStock1.NumberOfShare - userShare;
                        objStock1.NumberOfShare = availableShare;

                        Console.WriteLine("Total Share Price : " + totalSharePrice);
                        Console.WriteLine("Available Share ", objStock1.NameOfShare, availableShare);
                        TotalSharePrice = objStock1.SharePrice * objStock1.NumberOfShare;
                        Console.WriteLine("Name Of Stock : " + objStock1.NameOfShare);
                        Console.WriteLine("Total Share : " + objStock1.NumberOfShare);
                        Console.WriteLine("Each Share Price " + objStock1.SharePrice);
                    }

                    string jsonStock = JsonConvert.SerializeObject(objStock1);
                    Console.WriteLine(jsonStock);
                    StreamWriter streamWriter = new StreamWriter(FilePath);
                    streamWriter.WriteLine(jsonStock);
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("Invalide Formate Entered" + formatException);
                }
            }
        }

        /// <summary>
        /// Adds the stock.
        /// </summary>
        public void AddStock()
        {
            Console.WriteLine("Enter Number of stocks ");
            int numberOfStock = Convert.ToInt32(Console.ReadLine());
            StockReport[] stock = new StockReport[numberOfStock];

            for (int i = 0; i < numberOfStock; i++)
            {
                stock[i] = new StockReport();
                stock[i].InputStock();
            }

            List<StockReport> writeStock = new List<StockReport>();
            for (int i = 0; i < numberOfStock; i++)
            {
                writeStock.Add(stock[i]);
            }

            string jsonStock = JsonConvert.SerializeObject(stock, Formatting.Indented);
            StreamWriter streamWriter = new StreamWriter(PathFile);
            streamWriter.WriteLine(jsonStock);
            streamWriter.Close();
        }
    }
}
