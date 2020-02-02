using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class MonthlyPayment
    {
        public static void MoneyEMI()
        {
            Console.WriteLine("Enter Principle Amount");
            double P = Util.UserInput();
            Console.WriteLine("Enter Years");
            int Y = Util.userinputs();
            Console.WriteLine("Enter Rate of Intrest");
            double R = Util.UserInput();
            int n = 12 * Y;
            double r = R / (12 * 100);
            double Payment = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Principle Amount is " + Payment);

        }
    }
}
