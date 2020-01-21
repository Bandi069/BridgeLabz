using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class NumberGuessing
    {
        public static void GuessNumber()
        {
            int num = Utility.UserInput();
            int power = Utility.IsPower();
            if (power == 0)
            {
                Console.WriteLine("Number is not a power of 2");
            }
            else
            {
                
                int i, low = 0, high = num, mid;
                int[] array = new int[num];
                for (i = 0; i < num; i++)
                {
                    array[i] = i;
                }

                Console.WriteLine("Guess a number in your mind in range 0 to 2^n"+(num - 1));
              while (power > 0)
                {
                    mid = (low + high) / 2;
                    
                    if (Utility.IsBoolean(Console.ReadLine()))
                    {
                        Console.WriteLine("Yeah we won");
                        return;
                    }

                    if (Utility.IsBoolean(Console.ReadLine()))
                    {
                        high = mid;
                    }
                    else
                    {
                        low = mid + 1;
                    }

                    power--;
                }
            }
        }
    }
}
