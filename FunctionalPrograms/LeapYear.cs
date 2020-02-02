using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class LeapYear
    {
        public static void CheckLeapYear()
        { 
        Console.WriteLine("Enter Year : ");  
            int Year = Util.userinputs();
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine(Year+" is a Leap Year." );
            }
            else
            {
                Console.WriteLine(Year+" is not a Leap Year." );
            }
        }
    }

}
