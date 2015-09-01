using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    public class Game
    {

        public const int NUMBER_OF_PLAYERS = 4;
        private const int START_DICE_VALUE = 6;

        private readonly Dice dice;
        private readonly Player[] players;
        private readonly Table table;
        private int playerIndex;
        private int currentPlayerIndex;
        private readonly Player[] palpitating;
        private int palpitatingIndex;
        private int round;

        private Player CurrentPlayer
        {
            get
            {
                return this.players[this.currentPlayerIndex];
            }
        }

        public Game(Random random)
        {
            this.dice = new Dice(random);
            this.players = new Player[NUMBER_OF_PLAYERS];
            this.table = new Table();
            this.playerIndex = 0;
            this.currentPlayerIndex = 0;
            this.palpitating = new Player[3];
            this.palpitatingIndex = 0;
            this.round = 1;
        }

        public void AddPlayers(String first, String second, String third, String forth)
        {
            this.AddPlayer(first);
            this.AddPlayer(second);
            this.AddPlayer(third);
            this.AddPlayer(forth);
        }

        private void AddPlayer(String name)
        {
            if (this.playerIndex < this.players.Length)
            {
                this.players[this.playerIndex] = new Player(name, FigureColor.Values[this.playerIndex], this.table.PlayersDistance * this.playerIndex);
                this.playerIndex++;
            }
        }

        public bool IsFinish()
        {
            return this.palpitatingIndex == 3;
        }

        public String Step()
        {
            StringBuilder info = new StringBuilder(30);
            Player currentPlayer = this.CurrentPlayer;
            info.Append("R-").Append(this.round).Append(" ").Append(currentPlayer);
            if (!currentPlayer.IsFinish())
            {
                int diceValue = this.dice.Roll();
                info.Append(" Dice: ").Append(diceValue);
                if (this.IsStartFigurePossible(currentPlayer, diceValue))
                {
                    this.table.StartFigure(currentPlayer);
                    info.Append(" START ");
                }
                else
                {
                    this.table.MoveFigure(currentPlayer, diceValue);
                    info.Append(" STEP ");
                }
                if (currentPlayer.IsFinish())
                {
                    this.AddItemToPalpitating(currentPlayer);
                }
                if (diceValue != START_DICE_VALUE)
                {
                    this.NextPlayer();
                }
            }
            else
            {
                info.Append(" SKIP");
                this.NextPlayer();
            }
            return info.ToString();
        }

        private bool IsStartFigurePossible(Player player, int diceValue)
        {
            return diceValue == START_DICE_VALUE && player.HasFigureAtStart() && this.table.IsStartPossible(player);
        }

        private void AddItemToPalpitating(Player player)
        {
            if (this.palpitatingIndex < this.palpitating.Length)
            {
                this.palpitating[this.palpitatingIndex++] = player;
                player.End(this.round);
            }
        }

        private void NextPlayer()
        {
            if (this.currentPlayerIndex < this.players.Length - 1)
            {
                this.currentPlayerIndex++;
            }
            else
            {
                this.currentPlayerIndex = 0;
                this.round++;
            }
        }

        public String PrintPalpitating()
        {
            StringBuilder builder = new StringBuilder(50);
            for (int i = 0; i < this.palpitating.Length; i++)
            {
                builder.Append("[" + (i + 1) + "] ").Append(this.palpitating[i]).Append(" R-").Append(this.palpitating[i].WinningRound).Append("\n");
            }
            return builder.ToString();
        }

        public override String ToString()
        {
            return this.table.Print(this.players);
        }

    }
}
