﻿//<<auto-generated/>
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Utility
    {
        public static int UserInput()
        {
            return int.Parse(Console.ReadLine());
        }
        public static String InputString()
        {
            return Console.ReadLine();
        }
        public static bool IsBoolean(string input)
        {
            input.ToLower();
           
            while (string.Equals(input, "true") != true && string.Equals(input, "false") != true)
            {
                input.ToLower();
                Console.WriteLine("You have not entered a boolean value please try again");
                input = Console.ReadLine();
            }

            return input.Equals("true") ? true : false;
        }
        public static int IsPower()
        {
            int Power = 0, Number = 0, temp;
            temp = Number;
            while (temp > 0 && temp % 2 == 0)
            {
                if (temp / 2 == 1 && temp % 2 == 0)
                {
                    return ++Power;
                }
                temp = temp / 2;
                Power++;
            }
            return Number;
        }
        public static string[] MergeSortString(string[] a, int low, int high)
        {
            int mid = low + ((high - low) / 2);
            string[] r1 = new string[mid - low + 1], r2 = new string[high - mid], c = new string[high - low + 1];
            if (low < high)
            {
                r1 = MergeSortString(a, low, mid);
                r2 = MergeSortString(a, mid + 1, high);
                c = Combine(r1, mid - low + 1, r2, high - mid);
                return c;
            }
            else
            {
                
                c[0] = a[low];
                return c;
            }
        }
       
    }
}
