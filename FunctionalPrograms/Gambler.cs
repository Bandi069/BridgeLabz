// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
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
    /// Gambling class to find the wins and loss 
    /// </summary>
    class Gambler
    {
        /// <summary>
        /// Gamblings this instance.
        /// Static Method for Gambling 
        /// </summary>
        public static void Gambling()
        {
            //// Object for Random Number generator
            Random random = new Random();

            //// Giving inputs through util class 
            Console.WriteLine("enter stake: ");
            int stake = Util.userinputs();
            Console.WriteLine("enter goal: ");
            int goal = Util.userinputs();
            Console.WriteLine("enter no of trails:");
            int trials = Util.userinputs();

            int bets = 0;
            int wins = 0;
            int cash = stake;
            int loss = 0;
            for (int t = 0; t < trials; t++)
            {
                if (cash > 0 && cash < goal)
                {
                    bets++;
                    if (random.NextDouble() < 0.5)
                    {
                        cash++;
                        wins++;
                    }
                    else
                    {
                        cash--;
                        loss++;
                    }
                }
            }
            if (cash >= goal)
            {
                Console.WriteLine("goal reached");
            }
            else
            {
                Console.WriteLine("palyer lost");
            }

            //// Printing Loss,Wins and Percentages
            Console.WriteLine(wins + " wins of " + trials);
            Console.WriteLine(loss + " loss of " + trials);
            Console.WriteLine("Percent of games won = " + 100.0 * wins / trials);
            Console.WriteLine("percentage of games lost = " + 100.0 * loss / trials);
            Console.WriteLine("Avg # bets = " + 1.0 * bets / trials);

        }
    }
}


