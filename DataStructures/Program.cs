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
            Console.WriteLine("*****************");
            Console.WriteLine("1. UnOrder List");
            Console.WriteLine("2. Order List");
            Console.WriteLine("*****************");

            //// User Input value taken from utility class by calling 
           
            Console.WriteLine("Eneter Choice for required program to execute");
            int Choice = Utility.UserIntInput();
                    
            //// Switch case to different Programs 
            switch(Choice)
            {
              
               case 1: 
                UnOrderedList Obj = new UnOrderedList();
                Obj.UnorderList();
                break;
                case 2:
                    OrderedList ordlist = new OrderedList();
                    ordlist.orderedlist();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}
