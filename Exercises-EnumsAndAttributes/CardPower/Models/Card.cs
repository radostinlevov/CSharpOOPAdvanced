using System;

namespace CardPower.Models
{
    public class Card : IComparable<Card>
    {
        private Rank rank;
        private Suit suit;

        public Card(Rank rank, Suit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public int Power
        {
            get { return (int) this.rank + (int) this.suit; }
        }

        public int CompareTo(Card other)
        {
            return other.Power.CompareTo(this.Power);
        }

        public override string ToString()
        {
            return $"Card name: {this.rank} of {this.suit}; Card power: {this.Power}";
        }
    }
}