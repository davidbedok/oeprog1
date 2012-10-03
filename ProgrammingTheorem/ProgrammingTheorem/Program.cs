using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingTheorem
{
    public enum TransationCode
    {
        OpenAccount,
        AccountClosing
    }

    public class Program
    {

        private static void differenctCycleDemo()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 1, 2, 3, 4 };
            a[1] = new int[] { 5, 6 };
            a[2] = new int[] { 7, 8, 9 };

            {
                foreach (int[] itemA in a)
                {
                    foreach (int item in itemA)
                    {
                        System.Console.WriteLine(item);
                    }
                }
            }
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++)
                    {
                        System.Console.WriteLine(a[i][j]);
                    }
                }
            }
            {
                int i = 0;
                while (i < a.Length)
                {
                    int j = 0;
                    while (j < a[i].Length)
                    {
                        System.Console.WriteLine(a[i][j]);
                        j++;
                    }
                    i++;
                }
            }
        }

        private static void printArray( int[] data )
        {
            System.Console.Write("Array: ");
            foreach (int item in data)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            System.Console.WriteLine("ProgrammingTheorem Demo");   

            TheoremsTest.testSummation();
            TheoremsTest.testDecisionDivisible();
            TheoremsTest.testSelectionDivisible();
            TheoremsTest.testCountingDivisible();
            TheoremsTest.testMaximumSelection();
            TheoremsTest.testAssortmentDivisible();
            TheoremsTest.testSeparateParity();
            TheoremsTest.testUnion();
            TheoremsTest.testIntersect();
            TheoremsTest.testRunUpSortedSet();
            TheoremsTest.testSimpleSwapSort();
            TheoremsTest.testMinimumSelectionSort();
            TheoremsTest.testLinearSearch();
            TheoremsTest.testLinearSearchInSortedArray();
            TheoremsTest.testBinarySearch();
        }
    }
}
