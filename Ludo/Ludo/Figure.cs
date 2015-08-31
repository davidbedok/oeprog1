using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    public class Figure
    {

        private readonly Player player;
        private int position;
        private int distance;

        public Player Player
        {
            get { return this.player; }
        }

        public int Position
        {
            get { return this.position; }
        }

        public char Sign
        {
            get { return this.player.Sign; }
        }

        public Figure(Player player)
        {
            this.player = player;
            this.position = player.StartPosition;
            this.distance = 0;
        }

        public void SetPosition(int newPosition, int diceValue)
        {
            this.position = newPosition;
            this.distance += diceValue;
        }

        public bool IsHome()
        {
            return this.distance > Table.MAP_SIZE;
        }

    }
}
