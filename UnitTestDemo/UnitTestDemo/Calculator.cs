using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class Calculator
    {

        public static int CalculateIntegerDivision(int divident, int divisore)
        {
            int result = divident / divisore;
            if (result == 7)
            {
                result += 1;
            }
            return result;
        }

    }
}
