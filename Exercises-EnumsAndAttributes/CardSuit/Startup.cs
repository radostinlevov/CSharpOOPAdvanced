using System;

namespace CardSuit
{
    public class Startup
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();


            if (inputLine == "Card Suits")
            {
                Console.WriteLine($"{inputLine}:");

                foreach (var card in Enum.GetValues(typeof(CardSuits)))
                {
                    Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
                }
            }
        }
    }
}
