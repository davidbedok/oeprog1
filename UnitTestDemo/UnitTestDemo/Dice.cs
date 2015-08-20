using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestDemo
{
    public class Dice
    {
        private const int NUMBER_OF_SIDES = 6;

        private readonly RandomWrapper randomWrapper;

        public Dice(RandomWrapper randomWrapper)
        {
            this.randomWrapper = randomWrapper;
        }

        public int Roll()
        {
            return this.randomWrapper.Next(NUMBER_OF_SIDES);
        }

    }
}
