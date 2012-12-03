using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHunCard
{
    public class Card
    {
        private readonly CardRank rank;
        private readonly CardSuit suit;

        public Card(CardRank rank, CardSuit suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public int value()
        {
            return (int)rank * (int)suit;
        }

        public override string ToString()
        {
            return "Card [rank: "+rank+", suit: "+suit+"] " + value();
        }
    }
}
