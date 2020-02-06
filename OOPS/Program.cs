using OOPS.AddressBook;
using System;

namespace OOPS
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("1.Address Book");
            Console.WriteLine("Enter a number to run the required program");
            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    UserDetails userObj = new UserDetails();
                        userObj.userdetails();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }

        }
    }
}
