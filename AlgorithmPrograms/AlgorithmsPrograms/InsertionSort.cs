using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class InsertionSort
    {
        public static void InesrtionSorting()
        {
            Console.WriteLine("Enter The No elements of array");
            int n = Utility.UserInput();
            int[] arr = new int[n];
            Console.WriteLine("Enter Elements of array");
            int i, j = 0,temp;
            for (  i=0;i<n;i++)
            {
                arr[i]= Utility.UserInput();
            }
          
            for (i = 1; i < n; ++i)
            {
                int key = arr[i];
                j = i - 1;
             
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            for (i  = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
