// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Palindrome.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Palindrome
    {
        public void CheckPalindrome()
        {
            DeQueue<char> dequeue = new DeQueue<char>();
            Console.WriteLine("Enter a String to add Dequeue");
            string Str = Utility.UserStringInput();
            Char[] array = Str.ToCharArray();
            Console.WriteLine("Dequeue ");
            for (int i = 0; i < array.Length; i++)
            {
                dequeue.AddRear(array[i]);
            }

        }

    }
}
