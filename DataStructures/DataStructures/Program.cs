// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace DataStructures
{
    class Program
    {
        /// <summary>
        /// Main method for various Programs
        /// Using switch case to call the different Funcstions
        /// </summary>

        static void Main(string[] args)
        {
            //// Printing List of Programs 
            Console.WriteLine("*********************\n");
            Console.WriteLine("1. UnOrder List and Its implementation");
            Console.WriteLine("2. Order List and Its implementation");
            Console.WriteLine("3. Balanced Paranthesis");
            Console.WriteLine("4. Banking Counter ");
            Console.WriteLine("5. Palindromic Checker using Dequeue");
            Console.WriteLine("6. Print Calender Program");
            Console.WriteLine("7. Binary Search Tree Program");
            Console.WriteLine("8. Print Prime Range Program");
            Console.WriteLine("9. Hashing Function Program");
            Console.WriteLine("\n*********************");

            //// User Input value taken from utility class by calling 

            Console.WriteLine("Eneter Choice for required program to execute");
            int Choice = Utility.UserIntInput();

            //// Switch case to different Programs 
            switch (Choice)
            {

                case 1:
                    UnOrderedList Obj = new UnOrderedList();
                    Obj.UnorderList();
                    break;
                case 2:
                    OrderedList ordlist = new OrderedList();
                    ordlist.orderedlist();
                    break;
                case 3:
                    break;
                case 4:
                    BankQueue bankobj = new BankQueue();
                    bankobj.Bankqueue();
                    break;
                case 5:
                    Palindrome PaliObj = new Palindrome();
                    PaliObj.CheckPalindrome();
                    break;
                case 6:
                    Calender calobj = new Calender();
                    calobj.calender();
                    break;
                case 7:
                    BinarySearchTree BinaryObj = new BinarySearchTree();
                    BinaryObj.Tree();
                    break;
                case 8:
                    PrimeRange PrimeObj = new PrimeRange();
                    PrimeObj.printprimerange();
                    break;
                case 9:
                    HashingFunction HashObj = new HashingFunction();
                    HashObj.HashTable();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}
