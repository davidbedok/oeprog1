using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingTheorem
{
    public class MinimumSelector
    {

        private static void Main(string[] args)
        {
            Test();
            TestEffectiveVersion();
        }

        public static void Test()
        {
            int[] data = { 7, 4, 2, 7, 2, 9, 8, 2 };
            System.Console.WriteLine("input: " + ArrayToString(data));
            int[] minimums = AssortmentMinimums(data);
            System.Console.WriteLine("output: " + ArrayToString(minimums));
        }

        private static String ArrayToString(int[] elements)
        {
            return "[" + String.Join(", ", elements) + "]";
        }

        public static int[] AssortmentMinimums(int[] data)
        {
            int[] result = null;
            int min = MinimumSelection(data);
            if (min != -1)
            {
                int count = CountingItem(data, min);
                result = new int[count];
                int index = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    if (min == data[i])
                    {
                        result[index++] = i;
                    }
                }
            }
            return result;
        }

        private static int MinimumSelection(int[] data)
        {
            int min = -1;
            if (data.Length > 0)
            {
                min = data[0];
                for (int i = 1; i < data.Length; i++)
                {
                    if (min > data[i])
                    {
                        min = data[i];
                    }
                }
            }
            return min;
        }

        private static int CountingItem(int[] data, int item)
        {
            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == item)
                {
                    ++count;
                }
            }
            return count;
        }

        public static void TestEffectiveVersion()
        {
            int[] data = { 7, 4, 2, 7, 2, 9, 8, 2 };
            System.Console.WriteLine("input: " + ArrayToString(data));
            int[] minimums = EffectiveAssortmentMinimums(data);
            System.Console.WriteLine("output: " + ArrayToString(minimums));
        }

        public static int[] EffectiveAssortmentMinimums(int[] data)
        {
            int[] result = null;
            int[] minAndCount = MinimumSelectionAndCounting(data);
            if (minAndCount[0] != -1)
            {
                result = new int[minAndCount[1]];
                int index = 0;
                int i = 0;
                while (index < result.Length)
                {
                    if (minAndCount[0] == data[i])
                    {
                        result[index++] = i;
                    }
                    i++;
                }
            }
            return result;
        }

        private static int[] MinimumSelectionAndCounting(int[] data)
        {
            int[] result = new int[2];
            int min = -1;
            int count = 0;
            if (data.Length > 0)
            {
                min = data[0];
                count = 1;
                for (int i = 1; i < data.Length; i++)
                {
                    if (min > data[i])
                    {
                        min = data[i];
                        count = 1;
                    }
                    else if (min == data[i])
                    {
                        count++;
                    }
                }
            }
            result[0] = min;
            result[1] = count;
            return result;
        }

    }
}
