using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
	class Factorial	{
		public static void FactValue()
        {
            int i, fact = 1, number;
            Console.Write("Enter fact number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial " + number + " is: " + fact);
        }

    }
	
}
