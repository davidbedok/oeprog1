using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HunCard.CardEnum;

namespace HunCard
{
    public class Card : System.Object
    {
        private readonly CardSuit suit;
        private readonly CardRank rank;

        public CardSuit Suit
        {
            get { return this.suit; }
        }

        public CardRank Rank
        {
            get { return this.rank; }
        }

        public Card(CardSuit suit, CardRank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public int GetValue()
        {
            return (int)this.suit * (int)this.rank;
        }

        public override string ToString()
        {
            return ("Card: " + this.suit + ":" + this.rank + " value: " + this.GetValue());
        }

        // never use, only test
        public static Card GetRandomCard(Random rand)
        {
            // values of CardSuits have a programmed rule --> we use it --> evil design pattern
            int randSuit = rand.Next(1, 4);
            CardSuit iCardSuit = (CardSuit)randSuit;

            int randRank = rand.Next(0, 7);
            CardRank[] cardRanks = (CardRank[])Enum.GetValues(typeof(CardRank));
            CardRank iCardRank = cardRanks[randRank];
            /*
            CardRank iCardRank = CardRank.l7;
            switch (randRank)
            {
                case 0: iCardRank = CardRank.l7; break;
                case 1: iCardRank = CardRank.l8; break;
                case 2: iCardRank = CardRank.l9; break;
                case 3: iCardRank = CardRank.l10; break;
                case 4: iCardRank = CardRank.Also; break;
                case 5: iCardRank = CardRank.Felso; break;
                case 6: iCardRank = CardRank.Kiraly; break;
                case 7: iCardRank = CardRank.Asz; break;
            }
            */
            return new Card(iCardSuit, iCardRank);
        }

    }
}
