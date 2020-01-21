using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSort
    {
        public static void BubbleSorting()
        {
            Console.WriteLine("Enter the Number of elements to be sort");
            int n = Utility.UserInput();
            Console.WriteLine("ENter The Elements to Sort");
            int[] arr = new int[n];
            int temp,i;

            for (i=0;i<n;i++)
            {
                arr[i] = Utility.UserInput();
            }
            for (int j = 0; j <= n - 2; j++)
            {
                for (i = 0; i <= n - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                       
                    }
                }

            }
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
