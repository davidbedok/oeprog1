using System;
using System.Collections.Generic;
using System.Globalization;
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
                builder.Append(Convert.ToChar(random.Next((int)'A', ((int)'Z' + 1))));
            }
            return builder.ToString();
        }

        public static String createRandomName(Random random)
        {
            int chance = random.Next(0, 100);
            return createRandomNameParts(random, (chance < 5 ? 4 : chance < 25 ? 3 : 2), 8);
        }

        private static String createRandomNameParts(Random random, int size, int maximumLength)
        {
            StringBuilder name = new StringBuilder(size * maximumLength);
            for (int i = 0; i < size - 1; i++)
            {
                name.Append(createRandomNamePart(random, maximumLength)).Append(" ");
            }
            name.Append(createRandomNamePart(random, maximumLength));
            return name.ToString();
        }

        public static String createRandomNamePart(Random random, int maximumLength)
        {
            return createRandomString(random, 1) + createRandomString(random, random.Next(3, maximumLength - 1)).ToLower();
        }

        // return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(createRandomString(random, random.Next(3, 7)).ToLower());


        public static CarBrand createRandomBrand(Random random)
        {
            CarBrand[] values = (CarBrand[])Enum.GetValues(typeof(CarBrand));
            return values[random.Next(values.Length)];
        }

    }
}
