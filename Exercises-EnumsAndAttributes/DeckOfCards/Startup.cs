namespace DeckOfCards
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            string command = Console.ReadLine();

            if (command == "Card Deck")
            {
                foreach (var rank in Enum.GetValues(typeof(Rank)))
                {
                    Console.WriteLine($"{rank} of {Suit.Clubs}");
                }

                foreach (var rank in Enum.GetValues(typeof(Rank)))
                {
                    Console.WriteLine($"{rank} of {Suit.Diamonds}");
                }

                foreach (var rank in Enum.GetValues(typeof(Rank)))
                {
                    Console.WriteLine($"{rank} of {Suit.Hearts}");
                }

                foreach (var rank in Enum.GetValues(typeof(Rank)))
                {
                    Console.WriteLine($"{rank} of {Suit.Spades}");
                }
            }
        }
    }
}
