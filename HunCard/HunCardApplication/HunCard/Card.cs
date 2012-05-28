using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HunCard.CardEnum;

namespace HunCard
{
    public class Card : System.Object
    {
        private readonly CardSuit cardSuit;
        private readonly CardRank cardRank;

        public Card(CardSuit cardSuit, CardRank cardRank)
        {
            this.cardSuit = cardSuit;
            this.cardRank = cardRank;
        }

        public int getValue()
        {
            return ((int)cardSuit * (int)cardRank);
        }

        public override string ToString()
        {
            return ("Card: " + cardSuit.ToString() + ":" + cardRank.ToString() + " value: " + this.getValue());
        }

        // never use, only test
        public static Card getRandomCard(Random rand)
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
