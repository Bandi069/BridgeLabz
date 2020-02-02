using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class DayofWeek
    {
        public static void WeekDay()
        {
            Console.WriteLine("Enter Date");
            int d = Util.userinputs();
            Console.WriteLine("Enter Month");
            int m = Util.userinputs();
            Console.WriteLine("Enter Year");
            int y = Util.userinputs();
           int y0 = y - ( 14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
           int    m0 = m + 12 *((14 - m ) / 12) - 2;
            int   d0 = (d + x + 31*m0/ 12) % 7;
            int Day = d0;
            switch(Day)
            {
                case 0:
                    Console.WriteLine("sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednseday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Fri");
                    break;
                case 6:
                    Console.WriteLine("Sat");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;


            }
        }
    }
}
