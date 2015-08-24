using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HunCard
{
    public class Game : System.Object
    {
        private readonly Player[] players;
        private readonly Deck deck;
        private int numberOfPlayers;

        public Player this[int index]
        {
            get { return this.players[index]; }
            set { this.players[index] = value; }
        }

        public Game(Random rand, int maxNumberOfPlayers)
        {
            this.players = new Player[maxNumberOfPlayers];
            this.deck = new Deck(rand);
            this.numberOfPlayers = 0;
        }

        public void AddPlayer(Player player)
        {
            if (this.numberOfPlayers < this.players.Length)
            {
                this.players[this.numberOfPlayers++] = player;
            }
        }

        public void AddPlayer(String name)
        {
            this.AddPlayer(new Player(name));
        }

        private void RotateDeck()
        {
            this.deck.Rotate();
        }

        private void Division()
        {
            for (int i = 0; i < this.numberOfPlayers; i++)
            {
                for (int k = 0; k < Player.NUMBER_OF_PLAYER_CARDS; k++)
                {
                    this.players[i].AddCard(this.deck.GetTopCard());
                }
            }
        }

        private void DivisionWithIndexer()
        {
            for (int i = 0; i < this.numberOfPlayers; i++)
            {
                for (int k = 0; k < Player.NUMBER_OF_PLAYER_CARDS; k++)
                {
                    // [i] --> array index (this.players --> array type)
                    // [k] --> indexer index ( this.players[i] --> Player --> class type)
                    this.players[i][k] = this.deck.GetTopCard();
                }
            }
        }

        private Player GetWinner()
        {
            Player winner = null;
            if (this.numberOfPlayers > 0)
            {
                int maxValue = this.players[0].GetCardsValue();
                int maxPosition = 0;
                for (int i = 1; i < this.numberOfPlayers; i++)
                {
                    if (this.players[i].GetCardsValue() > maxValue)
                    {
                        maxValue = this.players[i].GetCardsValue();
                        maxPosition = i;
                    }
                }
                winner = this.players[maxPosition];
            }
            return winner;
        }

        public Player NewGame()
        {
            this.RotateDeck();
            this.Division();
            return this.GetWinner();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Game:");
            for (int i = 0; i < this.numberOfPlayers; i++)
            {
                builder.Append("[" + (i + 1) + "] ");
                builder.AppendLine(this.players[i].ToString());
            }
            builder.Append(this.deck.ToString());
            return builder.ToString();
        }

    }
}
