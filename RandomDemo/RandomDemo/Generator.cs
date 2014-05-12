using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomDemo
{
    public class Generator
    {

        public static int[] createRandomNumbers(Random random, int size, int range)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = random.Next(range);
            }
            return data;
        }

        public static int[] createRandomOrderedNumbers(Random random, int size)
        {
            int[] data = new int[size];
            data[0] = random.Next(1000);
            for (int i = 1; i < size; i++)
            {
                data[i] = data[i - 1] + random.Next(100);
            }
            return data;
        }

        public static int[] createRandomNumbersWithoutDuplicates(Random random, int size, int range)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                int k;
                int newNumber;
                do
                {
                    newNumber = random.Next(range);
                    k = 0;
                    while (k < i && data[k] != newNumber)
                    {
                        k++;
                    }
                } while (k != i);
                data[i] = newNumber;
            }
            return data;
        }

    }
}
