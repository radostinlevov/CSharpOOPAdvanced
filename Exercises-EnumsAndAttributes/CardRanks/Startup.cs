using System;

namespace CardRanks
{
   public class Startup
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();

            if (inputLine == "Card Ranks")
            {
                Console.WriteLine($"{inputLine}:");
                foreach (var card in Enum.GetValues(typeof(CardRanks)))
                {
                    Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
                }
            }
        }
    }
}
