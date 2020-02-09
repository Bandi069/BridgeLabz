// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
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
///Utility class  
/// </summary>
    class Utility
    {
        /// <summary>
        /// Users the int input.
        /// integer user input
        /// </summary>
        /// <returns UserIntInput></returns>
       public static int UserIntInput()
        {
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Users the string input.
        /// </summary>
        /// <returns UserString></returns>
        public static string UserStringInput()
        {
            return Console.ReadLine();
        }
        /// <summary>
        /// Factorials the specified number.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns fact></returns>
        public static int Factorial(int n)
        {
            int fact = 1;

            while (n > 0)
            {
                fact = fact * n;
                n--;
            }
            return fact;
        }
        /// <summary>
        ///  class for hashing Function
        /// </summary>
        public class HashingCal
        {
             int[,] hashvalue = new int[10, 10];
             int remainder = new int();
             int value;
            /// <summary>
            /// Hashes the function.
            /// </summary>
            /// <param name="list">The list.</param>
            /// <returns hashValue ></returns>
            public int[,] HashFunction(List<int> list)
            {
                int first = 0, second = 0, third = 0, 
                    fourth = 0, fifth = 0, sixth = 0, seventh = 0, eight = 0, ninth = 0, tenth = 0;
                foreach (int number in list)
                {
                    if (Remainder(number) == 0)
                    {
                        hashvalue[0, first] = number;
                        first++;
                    }
                    else if (Remainder(number) == 1)
                    {
                        hashvalue[1, second] = number;
                        second++;
                    }
                    else if (Remainder(number) == 2)
                    {
                        hashvalue[2, third] = number;
                        third++;
                    }
                    else if (Remainder(number) == 3)
                    {
                        hashvalue[3, fourth] = number;
                        fourth++;
                    }
                    else if (Remainder(number) == 4)
                    {
                        hashvalue[4, fifth] = number;
                        fifth++;
                    }
                    else if (Remainder(number) == 5)
                    {
                        hashvalue[5, sixth] = number;
                        sixth++;
                    }
                    else if (Remainder(number) == 6)
                    {
                        hashvalue[6, seventh] = number;
                        seventh++;
                    }
                    else if (Remainder(number) == 7)
                    {
                        hashvalue[7, eight] = number;
                        eight++;
                    }
                    else if (Remainder(number) == 8)
                    {
                        hashvalue[8, ninth] = number;
                        ninth++;
                    }
                    else if (Remainder(number) == 9)
                    {
                        hashvalue[9, tenth] = number;
                        tenth++;
                    }
                }
                return hashvalue;
            }

            /// <summary>
            /// Remainder of the specified number.
            /// </summary>
            /// <param name="number">The number.</param>
            /// <returns remainder></returns>
            public int Remainder(int number)
            {
                while (number > 9)
                {
                    this.remainder = number % 10;
                    number = number / 10;
                }
                return remainder;
            }
            /// <summary>
            /// Search the specified number.
            /// </summary>
            /// <param name="number">The number.</param>
            /// <returns value></returns>
            public int Search(int number)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (hashvalue[i, j] == number)
                        {
                            value = i;
                        }
                    }
                }
                return value;
            }

        }
    }
}
