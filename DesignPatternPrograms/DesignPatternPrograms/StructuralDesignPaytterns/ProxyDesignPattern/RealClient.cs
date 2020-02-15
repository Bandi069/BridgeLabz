using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPaytterns.ProxyDesignPattern
{
   public class RealClient :Client
    {
        string Data;
        public RealClient()
        {
            Console.WriteLine("It is Real Client");
        }
        public string GetData()
        {
            Console.WriteLine("Enter a String");
            Data = Console.ReadLine();
            return Data;
        }
    }
}
