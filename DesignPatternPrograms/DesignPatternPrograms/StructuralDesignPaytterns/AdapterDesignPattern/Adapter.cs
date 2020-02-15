using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.AdapterDesignPattern
{
    /// <summary>
    /// This is Adapter Class   
    /// </summary>
    public class Adaptee
    {
        /// <summary>
        /// String List
        /// </summary>
        /// <returns></returns>
        public List<string> GetList()
        {
            List<string> AdapterList = new List<string>();
            Console.WriteLine("Enter Number of adapts");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Adaptee List");

            for (int i = 0; i < Number; i++)
            {
                string Adaptee = Console.ReadLine();
                //// adding Adaptee to the list
                AdapterList.Add(Adaptee);
            }
            //// returning adapteList
            return AdapterList;
        }
        /// <summary>
        /// Adapter Target Interface Class
        /// </summary>
        public class Adapter : Target
        {
            /// <summary>
            /// Method to get the adaptee List
            /// </summary>
            /// <returns></returns>
            public List<string> GetList()
            {
                //// object for Adaptee
                Adaptee AdapteeObj = new Adaptee();
                return AdapteeObj.GetList();
            }

        }

    }
}
