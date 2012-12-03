using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHunCard
{
    public class Player
    {
        public const int CARDS_NUM = 3;

        private String name;
        private readonly Card[] cards;
        private int index;

        public Player(String name)
        {
            this.name = name;
            this.cards = new Card[Player.CARDS_NUM];
            this.index = 0;
        }

        public void addCard( Card card ) {
            if ( this.index < this.cards.Length) {
                this.cards[this.index++] = card;
            }
        }

        public void dropCards()
        {
            this.index = 0;
        }

        public int values()
        {
            int sum = 0;
            for (int i = 0; i < this.index; i++ ) {
                sum += this.cards[i].value();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder(50);
            info.Append("Player: " + name).AppendLine(" values: " + this.values());
            foreach ( Card card in this.cards ) {
                if (card != null)
                {
                    info.AppendLine(card.ToString());
                }
            }
            return info.ToString();
        }

    }
}
