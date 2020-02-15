using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPaytterns.ProxyDesignPattern
{
    public class ProxyObject : Client
    {
        RealClient RealClientObj = new RealClient();
        public ProxyObject()
        {
            Console.WriteLine("This is Proxy Object class");
        }
        public string GetData()
        {
            return RealClientObj.GetData();
        }
    }
}
