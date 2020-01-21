using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumbers
    {
        public static void PrintPrime()
        {
            Console.WriteLine("Enter a From Range Number");
            int P1 = Utility.UserInput();
            Console.WriteLine("Enter Range");
            int P2 = Utility.UserInput();
            int  i, j,Count=0;
            for(i = 1; i < P2;i++)
            {
                for (j = 2; j < i; j++)
               {
                    if(i%j==0)
                    {
                        Count = 0;
                        break;
                    } else
                    {
                        Count = 1;
                    }
                    
                }
                if (Count == 1)
                {
                    Console.Write(i + " ");
                }
            }

        }

    }
}
