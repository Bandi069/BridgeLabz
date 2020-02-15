using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.AdapterDesignPattern
{
    /// <summary>
    /// This is Adapter Class   
    /// </summary>
    public class Adapter
    {
        /// <summary>
        /// String List
        /// </summary>
        /// <returns></returns>
        public  List<string> GetList()
        {
                List<string> AdapterList = new List<string>();
                Console.WriteLine("Enter Number of adapts");
                int Number = int.Parse(Console.ReadLine());
                for (int i = 0; i < Number; i++)
                {
                    string Adaptee= Console.ReadLine();
                AdapterList.Add(Adaptee);
                }
            return AdapterList;
        }
    }
}
