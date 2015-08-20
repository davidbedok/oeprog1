using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class FakeRandomWrapper : RandomWrapper
    {

        private readonly int[] rolls;
        private int index;

        public FakeRandomWrapper(params int[] rolls)
            : base(null)
        {
            this.rolls = rolls;
            this.index = 0;
        }

        public override int Next(int maxValue)
        {
            return this.rolls[this.index++];
        }

    }
}
