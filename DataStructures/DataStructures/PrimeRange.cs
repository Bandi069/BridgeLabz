// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimRange.cs" company="Bridgelabz">
// Copyright © 2019  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    /// <summary>
    /// class for finding prime range
    /// </summary>
    class PrimeRange
    {
        /// <summary>
        /// Printprimeranges this instance.
        /// Method for printing prime Range
        /// </summary>
        public void printprimerange()
        {
            int[,] array = new int[0, 1000];
            int p = 0;
            int count = 0;
            int k = 1;
            for (int i = 2; i < 1; i++)
            {
                for (int j = 2; j < 1000; j++)
                {
                    array[i, j] = p;
                    p++;
                }
            }
            for (int i = 2; i < 1; i++)
            {
                for (int j = 2; j < 1000; j++)
                {
                    if (array[i, j] % k == 0)
                    {
                        int number = array[i, j];

                        bool prime = isPrime(number);

                        if (prime == true && number < 1000)
                        {
                            Console.WriteLine(array[i, j]);

                        }
                    }

                }
            }

        }
        /// <summary>
        /// Determines whether the specified number is prime.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        ///   <c>true</c> if the specified number is prime; otherwise, <c>false</c>.
        /// </returns>
        public bool isPrime(int number)
        {
            int count = 0;
            for (int index = 1; index < 1000; index++)
            {
                if (number % index == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
