using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHunCard
{
    public class Game
    {
        private const int PLAYER_NUM = 4; 

        private readonly Deck deck;
        private readonly Player[] players;
        private int playerIndex;

        public Game(Random rand)
        {
            this.deck = new Deck(rand);
            this.players = new Player[Game.PLAYER_NUM];
            this.playerIndex = 0;
        }

        private void addPlayer( Player player )
        {
            if (this.playerIndex < this.players.Length)
            {
                this.players[this.playerIndex++] = player;
            }
        }

        public void addPlayer(String name)
        {
            this.addPlayer(new Player(name));
        }

        public Player newGame()
        {
            this.deck.rotate();
            this.divideCards();
            return this.winner();
        }

        private void divideCards()
        {
            for (int i = 0; i < Player.CARDS_NUM; i++)
            {
                for (int j = 0; j < this.playerIndex; j++ )
                {
                    this.players[j].addCard(this.deck.topCard());
                }
            }
        }

        private Player winner()
        {
            Player player = null;
            if (this.playerIndex > 0)
            {
                player = this.players[0];
                int max = this.players[0].values();
                for (int i = 1; i < this.playerIndex; i++ )
                {
                    int currentMax = this.players[i].values();
                    if (currentMax > max)
                    {
                        max = currentMax;
                        player = this.players[i];
                    }
                }
            }
            return player;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder(200);
            info.AppendLine("HunCard game");
            for ( int i = 0; i < this.playerIndex; i++) {
                info.Append("[" + i + "]").AppendLine(this.players[i].ToString());
            }
            info.AppendLine(deck.ToString());
            return info.ToString();
        }

    }
}
