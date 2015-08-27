using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HunCard.CardEnum;

namespace HunCard
{
    public class Deck : System.Object
    {
        private const int NUMBER_OF_SWAPS = 100;

        private readonly Card[] cards;
        private readonly Random rand;
        private int topCardIndex;

        public Deck(Random rand)
        {
            this.rand = rand;
            CardSuit[] suits = (CardSuit[])Enum.GetValues(typeof(CardSuit));
            CardRank[] ranks = (CardRank[])Enum.GetValues(typeof(CardRank));
            this.cards = new Card[suits.Length * ranks.Length];
            for (int i = 0; i < suits.Length; i++)
            {
                for (int k = 0; k < ranks.Length; k++)
                {
                    this.cards[(i * 8) + k] = new Card(suits[i], ranks[k]);
                }
            }
            this.topCardIndex = 0;
        }

        public void Rotate()
        {
            this.Rotate(NUMBER_OF_SWAPS);
        }

        public void Rotate(int time)
        {
            for (int i = 0; i < time; i++)
            {
                this.SwapCards(this.rand.Next(this.cards.Length), this.rand.Next(this.cards.Length));
            }
            this.topCardIndex = 0;
        }

        private void SwapCards(int indexA, int indexB)
        {
            Card tmp = this.cards[indexA];
            this.cards[indexA] = this.cards[indexB];
            this.cards[indexB] = tmp;
        }

        // not use
        public Card GetRandomCardFromDeck()
        {
            // TODO
            return this.cards[this.rand.Next(0, this.cards.Length - 1)];
        }

        public Card GetTopCard()
        {
            if (this.topCardIndex >= this.cards.Length)
            {
                this.Rotate(NUMBER_OF_SWAPS); // !
            }
            return this.cards[this.topCardIndex++];
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Cards:");
            for (int i = 0; i < this.cards.Length; i++)
            {
                builder.Append("[" + (i + 1) + "] ");
                builder.Append(this.cards[i].ToString());
                if (this.topCardIndex == i)
                {
                    builder.Append(" <-- top");
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }

    }
}
