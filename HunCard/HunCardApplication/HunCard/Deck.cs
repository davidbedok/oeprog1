using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HunCard.CardEnum;

namespace HunCard
{
    public class Deck : System.Object
    {
        private const int NUMBER_OF_CARDS = 32;
        private const int NUMBER_OF_SWAPS = 100;

        private readonly Card[] cards;
        private readonly Random rand;
        private int topCardIndex;

        public Deck(Random rand)
        {
            this.rand = rand;
            this.cards = new Card[Deck.NUMBER_OF_CARDS];
            CardSuit[] suits = (CardSuit[])Enum.GetValues(typeof(CardSuit));
            CardRank[] ranks = (CardRank[])Enum.GetValues(typeof(CardRank));
            for (int i = 0; i < suits.Length; i++)
            {
                for (int k = 0; k < ranks.Length; k++)
                {
                    this.cards[(i * 8) + k] = new Card(suits[i], ranks[k]);
                }
            }
            this.topCardIndex = 0;
        }

        private void SwapCards(int indexA, int indexB)
        {
            Card tmp = this.cards[indexA];
            this.cards[indexA] = this.cards[indexB];
            this.cards[indexB] = tmp;
        }

        public void Rotate()
        {
            this.Rotate(Deck.NUMBER_OF_SWAPS);
        }

        public void Rotate(int time)
        {
            for (int i = 0; i < time; i++)
            {
                this.SwapCards(this.rand.Next(Deck.NUMBER_OF_CARDS), this.rand.Next(Deck.NUMBER_OF_CARDS));
            }
            this.topCardIndex = 0;
        }

        // not use
        public Card GetRandomCardFromDeck()
        {
            // TODO
            return this.cards[this.rand.Next(0, Deck.NUMBER_OF_CARDS - 1)];
        }

        public Card GetTopCard()
        {
            if (this.topCardIndex >= Deck.NUMBER_OF_CARDS)
            {
                this.Rotate(Deck.NUMBER_OF_SWAPS); // !
            }
            return this.cards[this.topCardIndex++];
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Cards:");
            for (int i = 0; i < Deck.NUMBER_OF_CARDS; i++)
            {
                builder.Append("[" + (i + 1) + "] ");
                builder.AppendLine(this.cards[i].ToString());
            }
            return builder.ToString();
        }

    }
}
