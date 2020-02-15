using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPaytterns.FacadeProductDesign
{
    /// <summary>
    /// 
    /// </summary>
    public class FacadeAddressBook : FacadeAddressBookDetails
    {
        public string FirstName()
        {
            Console.WriteLine("Enter FirstName:");
            string FirstName = Console.ReadLine();
            return FirstName;
        }
        public string LastName()
        {
            Console.WriteLine("Enter LastName:");
            string LastName = Console.ReadLine();
            return LastName;
        }
        public string Village()
        {
            Console.WriteLine("Enter Village:");
            string Village = Console.ReadLine();
            return Village;
        }
        public string City()
        {
            Console.WriteLine("Enter City:");
            string City = Console.ReadLine();
            return City;
        }
        public string State()
        {
            Console.WriteLine("Enter State:");
            string State = Console.ReadLine();
            return State;
        }
        public int Zipcode()
        {
            Console.WriteLine("Enter Zipcode:");
            int Zipcode = int.Parse(Console.ReadLine());
            return Zipcode;
        }
        public int PhoneNumber()
        {
            Console.WriteLine("Enter PhoneNumber:");
            int PhoneNumber = int.Parse(Console.ReadLine());
            return PhoneNumber;
        }


    }
}
