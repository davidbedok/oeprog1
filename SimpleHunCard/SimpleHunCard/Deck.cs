using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHunCard
{
    public class Deck
    {
        private const int ROTATE_FACTOR = 100;

        private readonly Card[] cards;
        private int topCardIndex;
        private readonly Random rand;

        public Deck(Random rand)
        {
            this.rand = rand;
            CardRank[] cardRanks = (CardRank[])Enum.GetValues(typeof(CardRank));
            CardSuit[] cardSuits = (CardSuit[])Enum.GetValues(typeof(CardSuit));

            this.cards = new Card[cardRanks.Length * cardSuits.Length];

            int index = 0;
            /*
            for (int i = 0; i < cardRanks.Length; i++ ) {
                for (int j = 0; j < cardSuits.Length; j++)
                {
                    this.cards[index++] = new Card(cardRanks[i], cardSuits[j]);
                }
            }
             * */
            foreach (CardSuit cardSuit in cardSuits)
            {
                foreach (CardRank cardRank in cardRanks)
                {
                    this.cards[index++] = new Card(cardRank, cardSuit);
                }
            }
            this.topCardIndex = 0;
        }

        public Card topCard()
        {
            Card topCard = null;
            if (this.topCardIndex < this.cards.Length)
            {
                topCard = this.cards[this.topCardIndex++];
            }
            return topCard;
        }

        private void changeCards( int indexA, int indexB )
        {
            Card tmpCard = this.cards[indexA];
            this.cards[indexA] = this.cards[indexB];
            this.cards[indexB] = tmpCard;
        }

        public void rotate()
        {
            int length = this.cards.Length;
            for (int i = 0; i < Deck.ROTATE_FACTOR; i++)
            {
                this.changeCards(this.rand.Next(length), this.rand.Next(length));
            }
            this.topCardIndex = 0;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder(100);
            info.AppendLine("# Deck");
            for (int i = 0; i < this.cards.Length; i++)
            {
                info.Append("[" + i + "]" ).Append(this.cards[i].ToString());
                if (i == this.topCardIndex)
                {
                    info.AppendLine(" <-- top card");
                }
                else
                {
                    info.AppendLine();
                }
            }
            return info.ToString();
        }

    }
}
