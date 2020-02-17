using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPrograms.StructuralDesignPaytterns.ProxyDesignPattern
{
    /// <summary>
    /// This is proxy Object Class
    /// </summary>
    public class ProxyObject : Client
    {
        /// <summary>
        /// Creating object to Real Client Class
        /// </summary>
        RealClient RealClientObj = new RealClient();
        /// <summary>
        /// This is ProxyObject Constructor
        /// </summary>
        public ProxyObject()
        {
            Console.WriteLine("This is Proxy Object class");
        }
        /// <summary>
        /// Method for Returning the GetData value
        /// </summary>
        /// <returns></returns>
        public string GetData()
        {
            //// Retruning GetData value
            return RealClientObj.GetData();
        }
    }
}
