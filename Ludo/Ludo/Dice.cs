using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    public class Dice
    {

        private const int MAX_VALUE = 6;

        private readonly Random random;

        public Dice(Random random)
        {
            this.random = random;
        }

        public int Roll()
        {
            return this.random.Next(Dice.MAX_VALUE) + 1;
        }

    }
}
