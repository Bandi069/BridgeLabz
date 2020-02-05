// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Array2D.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{
    /// <summary>
    ///  2D Array Class
    /// </summary>
    class Array2D
    {
        /// <summary>
        /// Prints the array.
        /// </summary>
        public static void PrintArray()
        {
            Console.WriteLine("Enter Rows and COlums");
            int m=Util.userinputs(); //// Taking rows from util class as user inputs
            int n = Util.userinputs(); //// Taking Colums from Util class as user input
            int i, j;
            int[,] arr = new int[m, n]; //// 2D attay Declaration
            Console.WriteLine("Enter Elements");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                  arr[i, j] = int.Parse(Console.ReadLine());
                
            }
            //// Pring Array 2D
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

