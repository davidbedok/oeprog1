using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HunCard.CardEnum;

namespace HunCard
{
    public class Player : System.Object
    {
        public const int NUM_OF_PLAYER_CARDS = 3;

        private string name;
        private Card[] cards;
        private int cardNum;

        // indexer
        public Card this[int index]
        {
            get { return this.cards[index]; }
            set { this.cards[index] = value; }
        }

        // for test indexer
        public Card getCardsItem(int index)
        {
            return this.cards[index];
        }

        // for test indexer
        public void setCardsItem(int index, Card value)
        {
            this.cards[index] = value;
        }

        public Player(string name)
        {
            this.name = name;
            this.cards = new Card[Player.NUM_OF_PLAYER_CARDS];
            this.cardNum = 0;
        }

        public void addCard(Card card)
        {
            if (this.cardNum < Player.NUM_OF_PLAYER_CARDS)
            {
                this.cards[this.cardNum++] = card;
            }
        }

        // not use
        public void addCard(CardSuit cardSuit, CardRank cardRank)
        {
            this.addCard(new Card(cardSuit, cardRank));
        }

        public void dropCards()
        {
            this.cardNum = 0;
        }

        public int getCardsValue()
        {
            int ret = 0;
            for (int i = 0; i < this.cardNum; i++)
            // for (int i = 0; i < Player.NUM_OF_PLAYER_CARDS; i++)
            {
                if (this.cards[i] != null)
                {
                    ret += cards[i].value();
                }
            }
            return ret;
        }

        public override string ToString()
        {
            // StringBuilder..
            string str = "Player " + this.name + "\n";
            for (int i = 0; i < this.cardNum; i++)
            // for (int i = 0; i < Player.NUM_OF_PLAYER_CARDS; i++)
            {
                if (this.cards[i] != null)
                {
                    str += "(" + (i + 1) + ") " + this.cards[i].ToString() + "\n";
                }
            }
            str += "SumValues: " + this.getCardsValue() + "\n";
            return str;
        }

    }
}
