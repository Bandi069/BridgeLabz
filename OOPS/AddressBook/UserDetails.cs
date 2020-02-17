// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserDetails.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
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
            var jsonfile = File.ReadAllText(@"C:\Users\Bridge Labs\Documents\GitHub\BridgeLabz\BridgeLabz\OOPS\AddressBook\JsonFile.json");
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
            var userArray = JsonObj.GetValue("AddressBook") as JArray;
            var newItemObj = JObject.Parse(NewUser);
            Console.WriteLine("NewUSer " + newItemObj);
            userArray.Add(newItemObj);
            JsonObj["AddressBook"] = userArray;
            string newJsonResult = JsonConvert.SerializeObject(JsonObj, Formatting.Indented);
            File.WriteAllText(this.jsonfile, newJsonResult);
            Console.WriteLine("New User Added to Json File");
        }
        public void UpdateFile()
        {
            string json = File.ReadAllText(jsonfile);
            try
            {
               
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception Occur" + e.Message);
            }

        }
    }
}