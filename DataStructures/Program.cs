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
            Console.WriteLine("*********************");
            Console.WriteLine("1. UnOrder List and Its Implementation");
            Console.WriteLine("2. Order List and its implementation");
            Console.WriteLine("3. Balanced Paranthesis");
            Console.WriteLine("4. Banking Counter ");
            Console.WriteLine("5. Palindromic Checker using Dequeue");
            Console.WriteLine("*********************");

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
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}
