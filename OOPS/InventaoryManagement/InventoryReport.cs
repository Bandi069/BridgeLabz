// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryReport.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OOPS.InventaoryManagement
{
    class InventoryReport
    {

        public void InventoryManagementReport()
        {
            
            double totalRicePrice = 0.0;
            double totalWheatsPrice = 0.0;
            double totalPulsesPrice = 0.0;
            string FilePath = @"C:\Users\Bridge Labs\source\repos\OOPS\OOPS\InventaoryManagement\JsonFile.json";
            var Json = File.ReadAllText(FilePath);
            InventoryReport utility = (InventoryReport)JsonConvert.DeserializeObject(Json, typeof(InventoryReport));
            foreach (var objRice in utility.Rice)
            {
                string name = objRice.Name;
                double price = objRice.Price;
                double weight = objRice.Weight;
                totalRicePrice = totalRicePrice + price * weight;
                Console.WriteLine("Name Of Rice :" + name);
                Console.WriteLine("Price :" + price);
                Console.WriteLine("Weight :" + weight);
            }
        }
    }
}
