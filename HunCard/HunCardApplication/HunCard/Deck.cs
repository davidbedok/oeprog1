using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HunCard.CardEnum;

namespace HunCard
{
    public class Deck : System.Object
    {
        // const: static readonly
        // byte, char, short, int, long, float, double, decimal, bool, string, an enum type
        // only possible values for constants of reference types are string and null
        // allow public visibility
        private const int NUM_OF_CARDS = 32;

        // can be any reference types
        // allow public visibility (static readonly)
        public static readonly int NUM_ROTATE = 100;

        private Card[] cards;
        private int topCardIndex;
        private Random rand;

        public Deck(Random rand)
        {
            this.rand = rand;
            this.cards = new Card[Deck.NUM_OF_CARDS];
            CardSuit[] cardSuits = (CardSuit[])Enum.GetValues(typeof(CardSuit));
            CardRank[] cardRanks = (CardRank[])Enum.GetValues(typeof(CardRank));
            for (int i = 0; i < cardSuits.Length; i++)
            {
                for (int j = 0; j < cardRanks.Length; j++)
                {
                    this.cards[(i * 8) + j] = new Card(cardSuits[i], cardRanks[j]);
                }
            }
            this.topCardIndex = 0;
        }

        private void changeCards(int indexA, int indexB)
        {
            Card tmp = this.cards[indexA];
            this.cards[indexA] = this.cards[indexB];
            this.cards[indexB] = tmp;
        }

        public void rotate()
        {
            this.rotate(Deck.NUM_ROTATE);
        }

        public void rotate(int time)
        {
            for (int i = 0; i < time; i++)
            {
                this.changeCards(this.rand.Next(Deck.NUM_OF_CARDS), this.rand.Next(Deck.NUM_OF_CARDS));
            }
            this.topCardIndex = 0;
        }

        // not use
        public Card getRandomCardFromDeck()
        {
            // TODO
            return this.cards[this.rand.Next(0, Deck.NUM_OF_CARDS-1)];
        }

        public Card getTopCard()
        {
            if (this.topCardIndex >= Deck.NUM_OF_CARDS)
            {
                this.rotate(Deck.NUM_ROTATE);
                // this is not too realistic..
            }
            return this.cards[this.topCardIndex++];
        }

        public override string ToString()
        {
            // StringBuilder..
            string str = "Cards:\n";
            for (int i = 0; i < Deck.NUM_OF_CARDS; i++)
            {
                str += "[" + (i + 1) + "] " + this.cards[i].ToString() + "\n";
            }
            return str;
        }

    }
}
