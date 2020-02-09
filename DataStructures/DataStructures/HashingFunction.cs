// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HAshingFunction.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static DataStructures.Utility;

namespace DataStructures
{
    class HashingFunction
    {
        static List<int> inputhash = new List<int>();
        static int[,] hasharray = new int[10, 10];

        /// <summary>
        /// Arrange the element using hastable.
        /// </summary>
        public void HashTable()
        {
            
            StreamReader sr = new StreamReader("C:/Users/tree/Documents/GitHub/BridgeLabz/DataStructures/DataStructures/HashingText.txt");
            string line = sr.ReadToEnd();
            string[] arr = line.Split(",");
            for (int i = 0; i < arr.Length; i++)
            {
                inputhash.Add(Convert.ToInt32(arr[i]));
            }
            HashingCal hash = new HashingCal();
         
            Console.WriteLine("Array Element");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(hasharray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter the Number to search");
            int num = Utility.UserIntInput();
            Console.WriteLine("Element found at" + (hash.Search(num) + 1) + "index in the hashtable");
        }

    }
}
