// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeckofCards.cs" company="Bridgelabz">
// Copyright © 2020  Company="BridgeLabz"
// </copyright>
// <creator name="Bandi Venu"/>
// --------------------------------------------------------------------------------------------------------------------

namespace OOPS
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using OOPS.DeckCards;
    /// <summary>
    /// Class for Deck of Cards
    /// </summary>
    class DeckOfCards
    {
        /// <summary>
        /// Method for Shuffling of Cards
        /// </summary>
        public void Shuffle()
        {
            //// Crreating Cardsplay Object
            CardsPlay DeckObj = new CardsPlay();
            string[] Deck = new string[52];
            string[] Suits = { "Spade", "Heart", "Diamond", "Club" };
            string[] Ranks = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "Jack", "Queen", "King", "Ace" };
            int Count = 0;
            for (int i = 0; i < Suits.Length; i++)
            {
                for (int j = 0; j < Ranks.Length; j++)
                {
                    Deck[Count] = Suits[i] + Ranks[j];
                    Count++;
                }
            }
            //// Calling PlayGame Method through DeckObject(Cardsplay Method)
            DeckObj.PlayGame(Deck);

        }

    }
}
