using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomDemo
{
    public enum Parity
    {
        EVEN,
        ODD
    }

    public enum CarBrand
    {
        ROVER, TOYOTA, SUZUKI, HONDA, FORD, SEAT, OPEL
    }

    public class Generator
    {

        public static int createRandomNumber(Random random, Parity parity, int minValue, int maxValue)
        {
            int baseValue = random.Next(minValue / 2, maxValue / 2);
            switch (parity)
            {
                case Parity.EVEN:
                    return baseValue * 2;
                case Parity.ODD:
                default:
                    return baseValue * 2 + 1;
            }
        }

        public static int[] createRandomNumbers(Random random, int size, int maxValue)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = random.Next(maxValue);
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

        public static int[] createUniqueRandomNumbers(Random random, int size, int maxValue)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                int k;
                int value;
                do
                {
                    value = random.Next(maxValue);
                    k = 0;
                    while (k < i && data[k] != value)
                    {
                        k++;
                    }
                } while (k != i);
                data[i] = value;
            }
            return data;
        }

        public static double createRandomRealNumber(Random random, int minValue, int maxValue)
        {
            return minValue + random.NextDouble() * (maxValue - minValue);
        }
        public static String createRandomString(Random random, int length)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                builder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))));
            }
            return builder.ToString();
        }

        public static String createRandomName(Random random)
        {
            return createRandomNamePart(random) + " " + createRandomNamePart(random);
        }

        public static String createRandomNamePart(Random random)
        {
            return createRandomString(random, 1) + createRandomString(random, random.Next(3, 7)).ToLower();
        }

        public static CarBrand createRandomBrand(Random random)
        {
            CarBrand[] values = (CarBrand[])Enum.GetValues(typeof(CarBrand));
            return (CarBrand)random.Next(values.Length);
        }


    }
}
