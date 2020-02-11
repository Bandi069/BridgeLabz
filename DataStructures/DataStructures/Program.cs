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
            Console.WriteLine("6. Hashing Table Implementation Program");
            Console.WriteLine("7. Print Prime Range Program");
            Console.WriteLine("9. Print Calender Program");
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
                    Hashing HashObj = new Hashing();
                    HashObj.HashingTable();
                    break;
                case 7:
                    PrimeRange PrimeObj = new PrimeRange();
                    PrimeObj.printprimerange();
                    break;
                case 9:
                    Calender calobj = new Calender();
                    calobj.calender();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}
