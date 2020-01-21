using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class MergeSort
    {
        public static void MergeSorting()
        {
            Console.WriteLine("Enter the string whose words are to be sorted");
            string s, temp = string.Empty;
            int count = 0, i = 0;
            s = Utility.InputString();
            foreach (char c in s)
            {
                if (c == ' ')
                {
                    count++;
                }
            }

            Console.WriteLine("number of spaces " + count);
            string[] stringarray = new string[count + 1];
            foreach (char c in s)
            {
                if (c == ' ')
                {
                    stringarray[i] = temp;
                    temp = string.Empty;
                    i++;
                }
                else
                {
                    temp = temp + c;
                }
            }

            stringarray[i] = temp;
            Console.WriteLine("Before sorting the srting is");
            for (i = 0; i <= count; i++)
            {
                Console.WriteLine(stringarray[i]);
            }

            stringarray = Utility.MergeSortString(stringarray, 0, count);
            Console.WriteLine("After sorting the srting is");
            for (i = 0; i <= count; i++)
            {
                Console.WriteLine(stringarray[i]);
            }
        }

    }
}   

