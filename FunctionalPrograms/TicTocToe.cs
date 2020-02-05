// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TicTOcToe.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalPrograms
{/// <summary>
/// TicTocTOe game class
/// </summary>
    class TicTocToe
    {
        static int player = 0;
        static int[,] BOARD = new int[3, 3];
        static bool isEmpty = true;
        /// <summary>
        /// Initializes the board.
        /// </summary>
        public static void initBoard()
        {
            Console.WriteLine("TICTACTOE Game\n1.Computer is X\n2.Player  is O ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    BOARD[i, j] = -10;
                }
            }
            Console.WriteLine("Board :");
            DisplayBoard();//// Calling Borad Display Function
        }
        /// <summary>
        /// Displays the board of the game.
        /// </summary>
        public static void DisplayBoard()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("---------------");
                Console.Write("||");
                for (int j = 0; j < 3; j++)
                {
                    if (BOARD[i, j] == 0)
                    {
                        count++;
                        Console.Write(" O |");
                    }
                    else if (BOARD[i, j] == 1)
                    {
                        count++;
                        Console.Write(" X |");
                    }
                    else
                        Console.Write("   |");
                }
                Console.WriteLine("|");
            }
            if (count == 9)
            {
                isEmpty = false;
            }
            Console.WriteLine("---------------");
        }
        /// <summary>
        /// Puts the value.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <param name="j">The j.</param>
        /// <param name="player">The player.</param>
        public void putVal(int i, int j, int player)
        {
            if (player % 2 == 0)
            {
                BOARD[i,j] = 0;
            }
            else
            {
                BOARD[i,j] = 1;
            } 
        }

        /// <summary>
        /// Puts the value.
        /// </summary>
        public static void putValue()
        {
            Random random = new Random();
            int i;
            int j;
            if (player % 2 == 1)
            {
                i = (int)(random.NextDouble() * 10) % 3;
                j = (int)(random.NextDouble() * 10) % 3;
            }
            else
            {

                Console.WriteLine("enter value of x and y by space");
                i = Util.userinputs(); //// Taking userinputs from Util Class
                j = Util.userinputs(); //// Taking userinputs from Util Class

            }
            if (BOARD[i, j] == -10)
            {
                if (player % 2 == 0)
                {
                    BOARD[i, j] = 0;
                }
                else
                {
                    BOARD[i, j] = 1;
                    Console.WriteLine("Coumputer Choosing " + i + " " + j);
                }
            }
            else
            {
                putValue(); //// Calling put vaue method
            }

        }
        /// <summary>
        /// Method for Wins printing
        /// Wins this instance.
        /// </summary>
        /// <returns></returns>
        public static bool win()
        {
            return ((BOARD[0, 0] + BOARD[0, 1] + BOARD[0, 2] == player * 3)
                 || (BOARD[1, 0] + BOARD[1, 1] + BOARD[1, 2] == player * 3)
                 || (BOARD[2, 0] + BOARD[2, 1] + BOARD[2, 2] == player * 3)
                 || (BOARD[0, 0] + BOARD[1, 0] + BOARD[2, 0] == player * 3)
                 || (BOARD[0, 1] + BOARD[1, 1] + BOARD[2, 1] == player * 3)
                 || (BOARD[0, 2] + BOARD[1, 2] + BOARD[2, 2] == player * 3)
                 || (BOARD[0, 0] + BOARD[1, 1] + BOARD[2, 2] == player * 3)
                 || (BOARD[2, 0] + BOARD[1, 1] + BOARD[0, 2] == player * 3));
        }

        /// <summary>
        /// Method for Playing the game
        /// Plays this instance.
        /// </summary>
        public static void play()
        {
            initBoard();
            while (isEmpty)
            {
                Console.WriteLine("Players turn");
                putValue();
                DisplayBoard();
                if (win())
                {
                    Console.WriteLine("Player won");
                    return;
                }
                player = 1;
                Console.WriteLine("Computers turn");
                putValue();
                DisplayBoard();
                if (win())
                {
                    Console.WriteLine("Computer won");
                    return;
                }
                player = 0;
            }
        }



    }
}

