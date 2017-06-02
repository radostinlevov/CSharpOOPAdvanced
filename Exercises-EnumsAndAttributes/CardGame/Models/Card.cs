namespace CardGame.Models
{
    using System;

    public class Card : IComparable<Card>
    {
        private Rank rank;
        private Suit suit;

        public Card(string cardRank, string cardSuit)
        {
            Rank rank;
            Suit suit;
            if (!Enum.TryParse(cardRank, out rank) ||
                !Enum.TryParse(cardSuit, out suit))
            {
                throw new ArgumentException("No such card exists.");
            }


            this.rank = rank;
            this.suit = suit;
        }

        public int Power
        {
            get { return (int)this.rank + (int)this.suit; }
        }

        public int CompareTo(Card other)
        {
            return other.Power.CompareTo(this.Power);
        }

        public override string ToString()
        {
            return $"{this.rank} of {this.suit}";
        }
    }
}