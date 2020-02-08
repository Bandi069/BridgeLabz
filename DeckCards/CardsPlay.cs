using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.DeckCards
{
    class CardsPlay
    {
        public  void PlayGame(string[] Deck)
        {
            int Players = 4;
            int TotalCards = Deck.Length;
            int PlayerCards = TotalCards / Players;
            //// Using 2D Array to print Cards and Rank of Players
            string[,] PlayersCards = new string[Players, PlayerCards];
            int i = 0, j = 0, k = 0;
            while (i < TotalCards)
            {
                j = j % Players;
                PlayersCards[j, k] = Deck[i];
                ++j; ++i;
                if (j == Players)
                {
                    ++k;
                }
            }
            for ( i = 0; i < 4; i++)
            {
                for ( j = 0; j < 9; j++)
                {
                    Console.Write
                        (PlayersCards[i,j]+",");
                }
                Console.WriteLine();
            }

        }
    }
}
