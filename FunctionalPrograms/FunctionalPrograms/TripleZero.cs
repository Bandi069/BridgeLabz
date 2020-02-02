using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class TripleZero
    {
        public static void SumZeroTriple()
        {
            Console.WriteLine("Enter Elements");

            int[] arr = { 2, 5, 7, -6, -1 };
            int n = arr.Length;
            /* for (int i = 0; i < n; i++)
             {
                 arr[i] = Console.ReadLine();
             }*/
            for (int i =0; i < n-2 ;i++)
            { 
                for (int j =0; j< n-1;j++)
                {
                    for (int k=0; k<n; k++)
                    {
                        if (arr[i] + arr[j]+arr[k]==0)
                        {
                            Console.WriteLine(arr[i] + "," + arr[j] + " , " + arr[k] + " is Zero");
                        } 
                    }
                }

            }
        }
    }
}
