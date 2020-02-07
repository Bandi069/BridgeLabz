﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace OOPS.AddressBook
{
    class AddressBookOperations
    {
        public void AddressOperations()
        {
            try
            {
                var addresspath = File.ReadAllText(@"C:\Users\Bridge Labs\source\repos\OOPS\OOPS\AddressBook\JsonFile.json");
                AddressBookList addressData = JsonConvert.DeserializeObject<AddressBookList>(addresspath);
                List<AddressDetails> addressBookList;

                if (addressData==null)
                {
                    addressBookList = new List<AddressDetails>();
                }
                else
                {
                    addressBookList = addressData.AddressBook;
                }
                bool status=true;
                while(status)
                {
                    UserDetails userDetailsObj = new UserDetails();
                    Console.WriteLine("Enter Choice for Operation");
                    Console.WriteLine("1. Adding user to the file");
                    Console.WriteLine("2. Update the file");
                    Console.WriteLine("3. Removing the User from the File");
                    
                    int Choice = int.Parse(Console.ReadLine());
                    switch(Choice)
                    {
                        case 1:
                         // userDetailsObj.userdetails(); //// To print the Jason Existing File by calling Userdetails Method
                            
                          userDetailsObj.AddUser();
                            break;

                        default:
                            Console.WriteLine("Entered Invalid Choice");
                            break;
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
