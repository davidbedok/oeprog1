using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HunCard.CardEnum;

namespace HunCard
{
    public class Player : System.Object
    {
        public const int NUMBER_OF_PLAYER_CARDS = 3;

        private readonly String name;
        private readonly Card[] cards;
        private int cardIndex;

        public Card this[int index]
        {
            get { return this.cards[index]; }
            set { this.cards[index] = value; }
        }

        public Card GetCard(int index)
        {
            return this.cards[index];
        }

        public void SetCard(int index, Card value)
        {
            this.cards[index] = value;
        }

        public Player(String name)
        {
            this.name = name;
            this.cards = new Card[Player.NUMBER_OF_PLAYER_CARDS];
            this.cardIndex = 0;
        }

        public void AddCard(Card card)
        {
            if (this.cardIndex < Player.NUMBER_OF_PLAYER_CARDS)
            {
                this.cards[this.cardIndex++] = card;
            }
        }

        // not use
        public void AddCard(CardSuit cardSuit, CardRank cardRank)
        {
            this.AddCard(new Card(cardSuit, cardRank));
        }

        public void DropCards()
        {
            this.cardIndex = 0;
        }

        public int GetCardsValue()
        {
            int ret = 0;
            for (int i = 0; i < this.cardIndex; i++)
            {
                if (this.cards[i] != null)
                {
                    ret += cards[i].GetValue();
                }
            }
            return ret;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Player " + this.name);
            for (int i = 0; i < this.cardIndex; i++)
            {
                if (this.cards[i] != null)
                {
                    builder.Append("(" + (i + 1) + ") ");
                    builder.AppendLine(this.cards[i].ToString());
                }
            }
            builder.AppendLine("SumValues: " + this.GetCardsValue());
            return builder.ToString();
        }

    }
}
