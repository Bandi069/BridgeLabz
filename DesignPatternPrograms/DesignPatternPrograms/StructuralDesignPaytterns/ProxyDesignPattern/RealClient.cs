using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPaytterns.ProxyDesignPattern
{
    /// <summary>
    /// This is Real Client Class 
    /// </summary>
    public class RealClient : Client
    {
        /// <summary>
        /// This is Data object giving as Public String 
        /// </summary>
        public string Data;
        /// <summary>
        /// This is Constructor 
        /// </summary>
        public RealClient()
        {
            Console.WriteLine("It is Real Client");
            Console.WriteLine("Enter a String");
            Data = Console.ReadLine();
        }
        /// <summary>
        /// This is GetData Method for returning Data
        /// </summary>
        /// <returns value="Data"></returns>
        public string GetData()
        {
            return Data;
        }
    }
}
