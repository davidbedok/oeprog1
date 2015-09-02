using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    public class Table
    {
        public const int MAP_SIZE = 40;

        private readonly List<Figure> figures;
        private readonly int playersDistance;

        public int PlayersDistance
        {
            get { return this.playersDistance; }
        }

        public Table()
        {
            this.figures = new List<Figure>();
            this.playersDistance = MAP_SIZE / Game.NUMBER_OF_PLAYERS;
        }

        public bool IsStartPossible(Player player)
        {
            Figure figure = this.FindFigure(player.StartPosition);
            return this.IsFreePosition(player, figure);
        }

        private Figure FindFigure(int position)
        {
            Figure figure = null;
            foreach (Figure current in this.figures)
            {
                if (current.Position == position)
                {
                    figure = current;
                    break;
                }
            }
            return figure;
        }
        private bool IsFreePosition(Player player, Figure figure)
        {
            return figure == null || figure.Player != player;
        }

        public void StartFigure(Player player)
        {
            Figure enemy = this.FindFigure(player.StartPosition);
            this.figures.Add(player.Start());
            this.HandleHit(player, enemy);
        }

        private void HandleHit(Player player, Figure enemy)
        {
            if (enemy != null)
            {
                player.Hit();
                enemy.Player.Death();
                this.figures.Remove(enemy);
            }
        }

        public void MoveFigure(Player player, int diceValue)
        {
            List<Figure> playerFigures = this.Assortment(player);
            playerFigures.Sort(new FigureDistanceComparer());
            foreach (Figure figure in playerFigures)
            {
                if (figure.IsHome(diceValue))
                {
                    figure.Player.Finish();
                    this.figures.Remove(figure);
                    break;
                }
                else
                {
                    int position = this.CalculateRealPosition(figure.Position + diceValue);
                    Figure enemy = this.FindFigure(position);
                    if (this.IsFreePosition(player, enemy))
                    {
                        figure.SetPosition(position, diceValue);
                        this.HandleHit(player, enemy);
                        break;
                    }
                }
            }
        }

        private List<Figure> Assortment(Player player)
        {
            List<Figure> figures = new List<Figure>();
            foreach (Figure current in this.figures)
            {
                if (current.Player.Equals(player))
                {
                    figures.Add(current);
                }
            }
            return figures;
        }

        private int CalculateRealPosition(int position)
        {
            return position >= MAP_SIZE ? position - MAP_SIZE : position;
        }

        public String Print(Player[] players)
        {
            StringBuilder builder = new StringBuilder(100);
            for (int i = 0; i < TableView.TYPE.Length; i++)
            {
                for (int k = 0; k < TableView.TYPE[i].Length; k++)
                {
                    char type = TableView.TYPE[i][k];
                    int owner = TableView.OWNER[i][k];
                    int index = TableView.INDEX[i][k];
                    switch (type)
                    {
                        case TableView.FIELD:
                            Figure figure = this.FindFigure(index);
                            builder.Append('[').Append(figure != null ? figure.Sign : ' ').Append(']');
                            break;
                        case TableView.START:
                            builder.Append(players[owner - 1].PrintStartFigure(index));
                            break;
                        case TableView.DESTINATION:
                            builder.Append(players[owner - 1].PrintFinishFigure(index));
                            break;
                        default:
                            builder.Append("   ");
                            break;
                    }
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }
    }
}
