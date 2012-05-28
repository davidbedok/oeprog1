using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HunCard
{
    public class Game : System.Object
    {
        private Player[] players;
        private int numOfPlayer;
        private int maxNumOfPlayer;
        private Deck gameDeck;

        // indexer
        public Player this[int index]
        {
            get { return this.players[index]; }
            set { this.players[index] = value; }
        }

        public Game(Random rand, int maxNumOfPlayer)
        {
            this.maxNumOfPlayer = maxNumOfPlayer;
            this.players = new Player[maxNumOfPlayer];
            this.gameDeck = new Deck(rand);
            this.numOfPlayer = 0;
        }

        public void addPlayer(Player player)
        {
            if (this.numOfPlayer < this.maxNumOfPlayer)
            {
                this.players[this.numOfPlayer++] = player;
            }
        }

        public void addPlayer(string name)
        {
            this.addPlayer(new Player(name));
        }

        private void rotate()
        {
            this.gameDeck.rotate();
        }

        private void dealer()
        {
            for (int i = 0; i < this.numOfPlayer; i++)
            {
                for (int j = 0; j < Player.NUM_OF_PLAYER_CARDS; j++)
                {
                    // [i] --> array index (this.players --> array type)
                    // [j] --> indexer index ( this.players[i] --> Player --> class type)
                    // this.players[i][j] = this.gamedeck.getTopCard();

                    // without indexer
                    // this.players[i].setCardsItem(j, this.gamedeck.getTopCard());

                    // best solution
                    this.players[i].addCard(this.gameDeck.getTopCard());
                }
            }
        }

        private Player getWinner (){
            Player winner = null;
            if ( this.numOfPlayer > 0 ){
                int max = this.players[0].getCardsValue();
                int maxpos = 0;
                for (int i = 1; i < this.numOfPlayer; i++)
                {
                    if (this.players[i].getCardsValue() > max)
                    {
                        max = this.players[i].getCardsValue();
                        maxpos = i;
                    }
                }
                winner = this.players[maxpos];
            }
            return winner;
        }

        public Player newGame()
        {
            this.rotate();
            this.dealer();
            return this.getWinner();
        }

        public override string ToString()
        {
            // StringBuilder
            string str = "Game:\n";
            for (int i = 0; i < this.numOfPlayer; i++) {
                str += "["+(i+1)+"] " + this.players[i].ToString();
            }
            str += this.gameDeck.ToString();
            return str;
        }

    }
}
