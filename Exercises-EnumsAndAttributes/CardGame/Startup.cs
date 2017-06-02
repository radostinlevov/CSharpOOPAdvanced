namespace CardGame
{
    using System;
    using System.Linq;
    using CardGame.Models;

    public class Startup
    {
        public static void Main()
        {
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            Player firstPlayer = new Player(firstPlayerName);

            while (firstPlayer.Cards.Count < 5)
            {
                try
                {
                    string[] cardDetails = Console.ReadLine().Split();
                    string cardRank = cardDetails[0];
                    string cardSuit = cardDetails[2];
                   
                    Card card = new Card(cardRank, cardSuit);
                    firstPlayer.AddCard(card);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            Player secondPlayer = new Player(secondPlayerName);

            while (secondPlayer.Cards.Count < 5)
            {
                try
                {
                    string[] cardDetails = Console.ReadLine().Split();
                    string cardRank = cardDetails[0];
                    string cardSuit = cardDetails[2];

                    Card card = new Card(cardRank, cardSuit);
                    secondPlayer.AddCard(card);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
            }

            Card firstPlayerCard = firstPlayer.Cards.First();
            Card secondPlayerCard = secondPlayer.Cards.First();

            if (firstPlayerCard.Power > secondPlayerCard.Power)
            {
                Console.WriteLine($"{firstPlayer.Name} wins with {firstPlayerCard}.");
            }
            else
            {
                Console.WriteLine($"{secondPlayer.Name} wins with {secondPlayerCard}.");
            }
        }
    }
}
