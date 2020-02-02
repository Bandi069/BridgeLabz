using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    class Array2D
    {
        public static void PrintArray()
        {
            Console.WriteLine("Enter Rows and COlums");
            int m=Util.userinputs();
            int n = Util.userinputs();
            int i, j;
            int[,] arr = new int[m, n];
            Console.WriteLine("Enter Elements");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                  arr[i, j] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Printing 2D Array: ");
            for ( i = 0; i < m; i++)
            {
                for ( j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }

}

