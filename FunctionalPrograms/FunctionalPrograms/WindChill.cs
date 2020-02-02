using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class WindChill
    {
        public static void FindWindChill()
        {
            Console.WriteLine("Enter Values ");
            double v = Util.UserInput();
            double t = Util.UserInput();
            double w = 35.74 + 0.6215 * t+(0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("Windchild Value is" + w);
          
        }
    }
}
