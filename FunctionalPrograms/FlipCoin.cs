// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipCoin.cs" company="Bridgelabz">
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
/// Flipcoin program 
/// gives numbers of Heads and trails on random
/// </summary>
    class FlipCoin
    {
        /// <summary>
        /// Method to find Flips the percent.
        /// </summary>
        public static void FlipPercent()
        {
            //// Object for Random Numbers  
            Random random = new Random();
            int headCount = 0;
            int tailCount = 0;
            int count = 1;
            Console.WriteLine("enter no of flips");
            int flips = Util.userinputs(); //// Takng integer input from Util class
            do
            {
                if (random.NextDouble() < 0.5)
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }
                count++;

            } while (count <= flips);
            //// Printing Number of heads and Tails
            Console.WriteLine("Total no of heads:" + headCount);
            Console.WriteLine("Total no of tails:" + tailCount);

        }

    }
}

