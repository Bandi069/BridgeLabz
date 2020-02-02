using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class TempConversion
    {
        public static void TempCon()
        {
            double Ftemp, Ctemp;
            Console.WriteLine(" Select Convesion type\n 1.Fahrenheit to celsius\n2. Celsius to  Fahrenheit");
            int Choice = Util.userinputs();
            switch(Choice)
            {
                case 1:
                    Console.WriteLine("Enter Fahrenheit Temp");
                     Ftemp = Util.userinputs();
                    Ctemp = (Ftemp - 32) * 5 / 9;
                    Console.WriteLine("Celsius TEmp" + Ctemp);
                    break;
                case 2:
                    Console.WriteLine("Enter  Celsius Temp");
                    Ctemp = Util.userinputs();
                    Ftemp = (Ctemp - 32) * 5 / 9;
                    Console.WriteLine("Fahrenheit TEmp" + Ftemp);
                    break;
                default :
                    Console.WriteLine("Invalid");
                    break;

            }
        }
    }
}
