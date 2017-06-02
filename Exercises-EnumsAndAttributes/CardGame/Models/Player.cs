namespace CardGame.Models
{
    using System;
    using System.Collections.Generic;

    public class Player
    {
        private string name;
        private SortedSet<Card> cards;

        public Player(string name)
        {
            this.name = name;
            this.cards = new SortedSet<Card>();
        }

        public string Name => this.name;

        public SortedSet<Card> Cards => this.cards;
        
        public void AddCard(Card card)
        {

            if (this.cards.Count > 0 && this.cards.Contains(card))
            {
                throw new ArgumentException("Card is not in the deck.");
            }

            this.cards.Add(card);
        }
    }
}