using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Distance
    {
        public static void CalculateDistance()
        {
            Console.WriteLine("Enter X and Y :");
            double x = Util.UserInput();
            double y = Util.UserInput();
            double Distance = Math.Sqrt(x * x - y * y);
            Console.WriteLine("Distance is " + Distance);

        }
    }
}
