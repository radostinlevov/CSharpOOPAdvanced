using System;
using System.Collections.Generic;
using System.Linq;
using CardPower.Models;

namespace CardPower
{
    public class Startup
    {
        static void Main()
        {
            SortedSet<Card> cards = new SortedSet<Card>();

            for (int i = 0; i < 2; i++)
            {
                string cardRank = Console.ReadLine();
                string cardSuit = Console.ReadLine();

                Rank rank = (Rank)Enum.Parse(typeof(Rank), cardRank);
                Suit suit = (Suit)Enum.Parse(typeof(Suit), cardSuit);

                Card card = new Card(rank, suit);
                cards.Add(card);
            }

            var first = cards.First();
            Console.WriteLine(first);
        }
    }
}
