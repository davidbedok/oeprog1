using System;
using System.Linq;

namespace ProgrammingTheorem
{
    public class UnionApplication
    {

        private static void Main(string[] args)
        {
            TestUnion();
            TestUnionWithLINQ();
        }

        private static void TestUnion()
        {
            int[] inputA = { 2, 5, 3, 12 };
            int[] inputB = { 8, 1, 2, 9, 3 };
            Console.WriteLine("(A): " + ArrayToString(inputA));
            Console.WriteLine("(B): " + ArrayToString(inputB));
            int[] output = Union(inputA, inputB);
            Console.WriteLine("(A union B): " + ArrayToString(output));
        }

        private static String ArrayToString(int[] elements)
        {
            return "[" + String.Join(", ", elements) + "]";
        }

        private static int[] UnionEmpty(int[] dataA, int[] dataB)
        {
            return new int[]{};
        }

        private static int[] Union(int[] dataA, int[] dataB)
        {
            int[] result = new int[dataA.Length + dataB.Length];
            int index = 0;
            for (int i = 0; i < dataA.Length; i++)
            {
                result[index++] = dataA[i];
            }
            for (int i = 0; i < dataB.Length; i++)
            {
                int k = 0;
                while ((k < dataA.Length) && (dataB[i] != dataA[k]))
                {
                    k++;
                }
                if (k == dataA.Length)
                {
                    result[index++] = dataB[i];
                }
            }
            return Cropping(result, index);
        }

        private static int[] Cropping(int[] source, int length)
        {
            int[] data = new int[length];
            if (length <= source.Length)
            {
                for (int i = 0; i < length; i++)
                {
                    data[i] = source[i];
                }
            }
            return data;
        }

        private static void TestUnionWithLINQ()
        {
            int[] inputA = { 2, 5, 3, 12 };
            int[] inputB = { 8, 1, 2, 9, 3 };
            Console.WriteLine("(A): " + ArrayToString(inputA));
            Console.WriteLine("(B): " + ArrayToString(inputB));
            int[] output = inputA.Union(inputB).ToArray();
            Console.WriteLine("(A union B): " + ArrayToString(output));
        }

    }
}
