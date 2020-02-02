using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class PowerTwo
    {
        public static void FindPower()
        {
            Console.WriteLine("Enter Required Power Number");
            int NumberValue = Util.userinputs();
            int PowerValue = 1;
            for (int i = 0; i < NumberValue; i++)
            {
                PowerValue = PowerValue*2;
            }
            Console.WriteLine("Power of 2 is " + PowerValue);
        }
    }
}
