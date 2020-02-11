// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryManagement.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq; //// Language Integrated Query
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Oops.InventaoryManagement
{
    /// <summary>
    /// Class for Inventory Management
    /// </summary>
    class InventoryManagement
    {
       //// Taking String thorugh Json file path
      public string JsonFile = @"C:\Users\Bridge Labs\source\repos\OOPS\OOPS\InventaoryManagement\JsonFile.json";
        /// <summary>
        /// Method for getting user Details
        /// </summary>
        public void GetDetails()
        {
            //// Read text from the Json File
            var Json = File.ReadAllText(this.JsonFile);
            try
            {
                //// Creating object and parsing it
                JObject Jsonobject = JObject.Parse(Json);
                if (Jsonobject != null)
                {
                    //// Creating an Array for Rice Object
                    JArray RiceArray = (JArray)Jsonobject["Rice"];
                    if (RiceArray != null)
                    {
                        ////foreach loop for Printing the rice array
                        foreach (var Riceitem in RiceArray)
                        {
                            Console.WriteLine("Name :" + Riceitem["Name"].ToString());
                            Console.WriteLine("Weight :" + Riceitem["Weight"].ToString());
                            Console.WriteLine("Price :" + Riceitem["Price"].ToString());
                        }
                    }
                    //// Creating wheat Array
                    JArray WheatArray = (JArray)Jsonobject["Wheat"];
                    if (WheatArray != null)
                    {
                        ////foreach loop for Printing the Wheat array
                        foreach (var Wheatitem in WheatArray)
                        {
                            Console.WriteLine("Name :" + Wheatitem["Name"].ToString());
                            Console.WriteLine("Weight :" + Wheatitem["Weight"].ToString());
                            Console.WriteLine("Price :" + Wheatitem["Price"].ToString());
                        }
                    }
                    //// Creating and Parsing Pukse Array
                    JArray PulseArray = (JArray)Jsonobject["Pulses"];
                    if (PulseArray != null)
                    {
                        ////foreach loop for Printing the Pulse array
                        foreach (var Pulseitem in PulseArray)
                        {
                            Console.WriteLine("Name :" + Pulseitem["Name"].ToString());
                            Console.WriteLine("Weight :" + Pulseitem["Weight"].ToString());
                            Console.WriteLine("Price :" + Pulseitem["Price"].ToString());
                        }
                    }
                }
            }
            //// Catch loop for Exception 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Method to Adding item to the Json file 
        /// Taking Json file And adding a new item to file 
        /// </summary>
        public void AddItem()
        {
            Console.WriteLine("Enter New Item Name : ");
            var NewitemName = Console.ReadLine();
            Console.WriteLine("Enter type of New Item : ");
            string NewitemType = Console.ReadLine();
            Console.WriteLine("Enter New adding Item Price : ");
            var NewitemPrice = Console.ReadLine();
            Console.WriteLine("Enter New adding Item Weight : ");
            var NewitemWeight = Console.ReadLine();
            var NewItem = "{ 'Name': '" + NewitemType + "','Price':" + NewitemPrice + ",'Weight':" + NewitemWeight + "}";
            var json = File.ReadAllText(this.JsonFile);
            JObject jsonObj = JObject.Parse(json);
            var itemArray = jsonObj.GetValue(NewitemName) as JArray;

            var newItemObj = JObject.Parse(NewItem);
            Console.WriteLine("Newitem " + newItemObj);
            itemArray.Add(newItemObj);
            Console.WriteLine("Name :" + itemArray);
            jsonObj[NewitemName] = itemArray;
            
            string newJsonResult = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(this.JsonFile, newJsonResult);

        }
        /// <summary>
        /// Method to Update the Json file
        /// It gives the output file with adding items
        /// </summary>
        public void UpdateFile()
        {
            //// Reading File from its Path
            var Updatejson = File.ReadAllText(this.JsonFile);
            try
            {
                var jsonobject = JObject.Parse(Updatejson);
                Console.WriteLine("Enter Item to Update");
                var UpdateItemName = Console.ReadLine();
                JArray RiceArrary = (JArray)jsonobject[UpdateItemName];
                Console.Write("Enter Item Name to Update : ");
                var itemName = Console.ReadLine();
                Console.Write("Enter new Item name : ");
                var newItemName = Convert.ToString(Console.ReadLine());

                foreach (var item in RiceArrary.Where(obj => obj["Name"].Value<string>().Equals(itemName)))
                {
                    item["Name"] = !string.IsNullOrEmpty(newItemName) ? newItemName : string.Empty;
                }

                jsonobject["Name"] = RiceArrary;
                string Result = JsonConvert.SerializeObject(jsonobject, Formatting.Indented);
                File.WriteAllText(this.JsonFile, Result);
                Console.WriteLine(newItemName + " is Updated " + itemName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs" + e.Message);
            }

        }
        /// <summary>
        /// Method to Delete item from the Json File 
        /// It Deletes the item from the array  
        /// Gives Json file by deleting the item
        /// </summary>
        public void DeleteItem()
        {
            var json = File.ReadAllText(this.JsonFile);
            try
            {
                JObject Jsondeleteobj = JObject.Parse(json);
                Console.WriteLine("Enter item to delete");
                var DeleteItem = Console.ReadLine();
                JArray DeleteArray = (JArray)Jsondeleteobj[DeleteItem];
                Console.WriteLine("Enter Name of item to Delete");
                var itemdelete = Console.ReadLine();
                var itemToDeleted = DeleteArray.FirstOrDefault(obj => obj["Name"].Value<string>().Equals(itemdelete));
                DeleteArray.Remove(itemToDeleted);

                string Result = JsonConvert.SerializeObject(Jsondeleteobj, Formatting.Indented);
                File.WriteAllText(this.JsonFile, Result);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception :" + e.Message);
            }
        }
    }
}
