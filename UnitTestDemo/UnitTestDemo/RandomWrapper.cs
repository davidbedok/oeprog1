using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class RandomWrapper
    {

        private readonly Random random;

        public RandomWrapper(Random random)
        {
            this.random = random;
        }

        public virtual int Next(int maxValue)
        {
            return this.random.Next(maxValue) + 1;
        }

    }
}
