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
<<<<<<< HEAD
    class InventoryReport
    {

        public void InventoryManagementReport()
        {

            double totalRicePrice = 0.0;
=======
   public class InventoryReport
    {
        public string Wheat { get; set; }
        public string Pulses { get; set; }
        public string Rice { get; set; }
        public static void InventoryManagementReport()
        {
            
        double totalRicePrice = 0.0;
>>>>>>> 0719d6bd675447eb14e05ecd50c0f34251333d15
            double totalWheatsPrice = 0.0;
            double totalPulsesPrice = 0.0;
            string FilePath = @"C:\Users\Bridge Labs\source\repos\OOPS\OOPS\InventaoryManagement\JsonFile.json";
            var Json = File.ReadAllText(FilePath);
<<<<<<< HEAD
            InventoryReport utility = (InventoryReport)JsonConvert.DeserializeObject(Json, typeof(InventoryReport));
          /*  foreach (var objRice in utility.Rice)
=======
            InventoryReport JInventoryobj = (InventoryReport)JsonConvert.DeserializeObject(Json, typeof(InventoryReport));
            foreach (var objRice in JInventoryobj.Rice)
>>>>>>> 0719d6bd675447eb14e05ecd50c0f34251333d15
            {
                string name = objRice.Name;
                double price = objRice.Price;
                double weight = objRice.Weight;
                totalRicePrice = totalRicePrice + price * weight;
                Console.WriteLine("Name Of Rice :" + name);
                Console.WriteLine("Price :" + price);
                Console.WriteLine("Weight :" + weight);
<<<<<<< HEAD
            }*/
        }
    }
=======
            }
            Console.WriteLine("Total Amount Of Rice :" + totalRicePrice);

            foreach (Wheat objWheat in JInventoryobj.Wheat)
            {
                string name = objWheat.Name;
                double price = objWheat.Price;
                double weight = objWheat.Weight;
                totalWheatsPrice = totalWheatsPrice + price * weight;
                Console.WriteLine("\nName Of Wheats :" + name);
                Console.WriteLine("Price :" + price);
                Console.WriteLine("Weight :" + weight);
            }
            Console.WriteLine("Total Amount Of Wheats :" + totalWheatsPrice);

            foreach (Pulses objPulses in JInventoryobj.Pulses)
            {
                string name = objPulses.Name;
                double price = objPulses.Price;
                double weight = objPulses.Weight;
                totalPulsesPrice = totalPulsesPrice + price * weight;
                Console.WriteLine("\nName Of Pulses :" + name);
                Console.WriteLine("Price :" + price);
                Console.WriteLine("Weight :" + weight);
            }
            Console.WriteLine("Total Amount Of Pulses :" + totalPulsesPrice);
        }
    }
    }
>>>>>>> 0719d6bd675447eb14e05ecd50c0f34251333d15
}
