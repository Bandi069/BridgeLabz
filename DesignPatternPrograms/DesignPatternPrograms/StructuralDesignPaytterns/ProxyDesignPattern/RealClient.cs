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
            Console.WriteLine("it is Real Client");
        }
    }
}
