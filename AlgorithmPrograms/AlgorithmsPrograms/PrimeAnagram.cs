using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeAnagram
    { public static void PrimeAnagramPalindrome()
        {
            Console.WriteLine("Enter a Range");
            int n1 = Utility.UserInput();
            printPalPrimes(n1);
        }
            static void printPalPrimes(int n1)
            {
               bool[] prime = new bool[n1 + 1];

                for (int i = 0; i < n1 + 1; i++)
                    prime[i] = true;

                for (int p = 2; p * p <= n1; p++)
                {
                    if (prime[p] )
                    {
                        for (int i = p * 2; i <= n1; i += p)
                        {
                            prime[i] = false;
                        }
                    }
                }
                for (int p = 2; p <= n1; p++)
                {
                    if (prime[p] && isPal(p))
                    {
                        Console.Write(p + " ");
                    }
                }
            }
        static bool oneDigit(int num)
        {
            return (num >= 0 && num <1000);
        }

         
        static bool isPalUtil(int num, int dupNum)
        {
            if (oneDigit(num))
                return (num == (dupNum) % 10);

            if (!isPalUtil(num / 10, dupNum))
                return false;
            dupNum /= 10;
            return (num % 10 == (dupNum) % 10);
        }
       
        static bool isPal(int num)
        {
            if (num < 0)
                num = -num;
           int dupNum = num; 

            return isPalUtil(num, dupNum);
        }

    }
}
