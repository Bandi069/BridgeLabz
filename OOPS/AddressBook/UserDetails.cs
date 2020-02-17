// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDetails.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace OOPS.AddressBook
{
    class UserDetails
    {
        private string jsonfile;

        public void userdetails()
        {
            var jsonfile = File.ReadAllText(@"C:\Users\tree\Documents\GitHub\BridgeLabz\AddressBook\JsonFile.json");
            try
            {
                var JsonObject = JObject.Parse(jsonfile);
                if (JsonObject != null)
                {
                    JArray UserDetailsArray = (JArray)JsonObject["AddressBook"];
                    if (UserDetailsArray != null)
                    {
                        foreach (var user in UserDetailsArray)
                        {
                            Console.WriteLine("FirstName :" + user["FirstName"].ToString());
                            Console.WriteLine("LastName :" + user["LastName"].ToString());
                            Console.WriteLine("Village :" + user["Village"].ToString());
                            Console.WriteLine("City:" + user["City"].ToString());
                            Console.WriteLine("State :" + user["State"].ToString());
                            Console.WriteLine("Zipcode :" + user["Zipcode"].ToString());
                            Console.WriteLine("PhoneNumber :" + user["PhoneNumber"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void AddUser()
        {
            Console.WriteLine("Enter The First Name");
            var FirstName = Console.ReadLine();
            Console.WriteLine("Enter The Last Name");
            var LastName = Console.ReadLine();
            Console.WriteLine("Enter the Village Name");
            var Village = Console.ReadLine();
            Console.WriteLine("Enter the City Name");
            var City = Console.ReadLine();
            Console.WriteLine("Enter the State Name");
            var State = Console.ReadLine();
            Console.WriteLine("Enter the Zipcode");
            var Zipcode = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            var PhoneNumber = Console.ReadLine();
            var NewUser = "{ 'FirstName': '" + FirstName + "','LastName':'" + LastName + "','Village':'" + Village + "','State':'" + State + "','City':'" + City + "','PhoneNumber':" + PhoneNumber + ",'Zipcode':" + Zipcode + "}";
            var NewjasonFile = File.ReadAllText(this.jsonfile);
            var JsonObj = JObject.Parse(NewjasonFile);
            var userArrary = JsonObj.GetValue("AddressBook") as JArray;
            var newItemObj = JObject.Parse(NewUser);
            Console.WriteLine("NewUSer " + newItemObj);
            userArrary.Add(newItemObj);
            JsonObj["AddressBook"] = userArrary;
            string newJsonResult = JsonConvert.SerializeObject(JsonObj, Formatting.Indented);
            File.WriteAllText(this.jsonfile, newJsonResult);
            Console.WriteLine("New User Added to Json File");
        }
        /// <summary>
        /// Updates the file.
        /// This is the method to update the json file
        /// </summary>
        public void UpdateFile()
        {
            string json = File.ReadAllText(jsonfile);
            try
            {
                var jsonObject = JObject.Parse(json);
                Console.WriteLine("Enter Item Name ");
                string itemNameToUpdate = Console.ReadLine();
                JArray addressArrary = (JArray)jsonObject[itemNameToUpdate];
                Console.Write("Enter Item Name to Update : ");
                var itemName = Console.ReadLine();
                Console.Write("Enter new First name to update ");
                var newFirstName = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new lastname  to update  ");
                var newLastName = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new Village name to update ");
                var newVillage = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new State name : ");
                var newState = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new City name to update: ");
                var newCity = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new PhoneNumber to update ");
                var newPhoneNumber = Convert.ToString(Console.ReadLine());
                Console.Write("Enter new Zipcode  to update : ");
                var newZipcode = Convert.ToString(Console.ReadLine());
                var newItem = "{ 'FirstName': '" + newFirstName + "','LastName':'" + newLastName + "','Village':'" + newVillage + "','State':'" + newState + "','City':'" + newCity + "','PhoneNumber':'" + newPhoneNumber + "','Zipcode':'" + newZipcode + "'}";
                var itemArrary = jsonObject.GetValue("newItem") as JArray;

                foreach (var item in addressArrary.Where(obj => obj["FirstName"].Value<string>().Equals(itemName)).ToList())
                {
                    item["FirstName"] = !string.IsNullOrEmpty(newFirstName) ? newFirstName : string.Empty;
                    item["LastName"] = !string.IsNullOrEmpty(newLastName) ? newLastName : string.Empty;
                    item["Address"] = !string.IsNullOrEmpty(newVillage) ? newVillage : string.Empty;
                    item["State"] = !string.IsNullOrEmpty(newState) ? newState : string.Empty;
                    item["City"] = !string.IsNullOrEmpty(newCity) ? newCity : string.Empty;
                    item["PhoneNumber"] = !string.IsNullOrEmpty(newPhoneNumber) ? newPhoneNumber : string.Empty;
                    item["Zipcode"] = !string.IsNullOrEmpty(newZipcode) ? newZipcode : string.Empty;
                }

                jsonObject["AddressBook"] = addressArrary;
                string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                File.WriteAllText(this.jsonfile, output);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occur : " + e.Message);
            }
        }

        /// <summary>
        /// Deletes the item from the json file.
        /// </summary>
        public void DeleteUser()
        {
            var jsonFileRead = File.ReadAllText(this.jsonfile);
            try
            {
                var jsonObject = JObject.Parse(jsonFileRead);
                Console.WriteLine("Enter Item Name to delete ");
                string itemNameToDelete = Console.ReadLine();
                JArray itemsArrary = (JArray)jsonObject[itemNameToDelete];
                Console.Write("Enter Name from list to  Delete Item  ");
                var itemName = Console.ReadLine();
                var itemToDeleted = itemsArrary.FirstOrDefault(obj => obj["FirstName"].Value<string>() == itemName);
                itemsArrary.Remove(itemToDeleted);

                string output = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                File.WriteAllText(this.jsonfile, output);
                Console.WriteLine("Required Item Deleted Successfully from the list");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occurs : " + e.Message);
            }
        }
    }

}

