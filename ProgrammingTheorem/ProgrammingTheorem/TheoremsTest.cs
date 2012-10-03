using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingTheorem
{
    public class TheoremsTest
    {

        public static void testSummation()
        {
            System.Console.WriteLine("# summation");
            int[] data = { 30, 20, 40, 10 };
            System.Console.WriteLine("input: " + Arrays.toString(data));
            System.Console.WriteLine("output: " + Theorems.summation(data));
        }

        public static void testDecisionDivisible()
        {
            System.Console.WriteLine("# decisionDivisible (3)");
            int[] data = { 6, 4, 2, 8 };
            System.Console.WriteLine("input: " + Arrays.toString(data));
            System.Console.WriteLine("output: " + Theorems.decisionDivisible(data, 3));
        }

        public static void testSelectionDivisible()
        {
            System.Console.WriteLine("# selectionDivisible (3)");
            int[] data = { 2, 6, 4, 8 };
            System.Console.WriteLine("input: " + Arrays.toString(data));
            System.Console.WriteLine("output (index): " + Theorems.selectionDivisible(data, 3));
        }

        public static void testCountingDivisible()
        {
            System.Console.WriteLine("# countingDivisible (3)");
            int[] data = { 4, 1, 6, 12, 7, 5 };
            System.Console.WriteLine("input: " + Arrays.toString(data));
            System.Console.WriteLine("output: " + Theorems.countingDivisible(data, 3));
        }

        public static void testMaximumSelection()
        {
            System.Console.WriteLine("# maximumSelection");
            int[] data = { 3, 7, 1, 13, 4, 8 };
            System.Console.WriteLine("input: " + Arrays.toString(data));
            System.Console.WriteLine("output: " + Theorems.maximumSelection(data));
        }

        public static void testAssortmentDivisible()
        {
            System.Console.WriteLine("# assortmentDivisible (3)");
            int[] data = { 2, 15, 7, 6, 9, 12, 11 };
            System.Console.WriteLine("input: " + Arrays.toString(data));
            int[] divisibleData = Theorems.assortmentDivisible(data, 3);
            System.Console.WriteLine("output: " + Arrays.toString(divisibleData));
        }

        public static void testSeparateParity()
        {
            System.Console.WriteLine("# separateParity");
            int[] data = { 6, 1, 5, 2, 4, 9, 7, 3, 8 };
            System.Console.WriteLine("input: " + Arrays.toString(data));
            int[][] separateNumbers = Theorems.separateParity(data);
            System.Console.WriteLine("even numbers: " + Arrays.toString(separateNumbers[0]));
            System.Console.WriteLine("odd numbers: " + Arrays.toString(separateNumbers[1]));
            // C# our, ref params - not scope
        }

        public static void testUnion()
        {
            System.Console.WriteLine("# union");
            int[] dataA = { 2, 5, 3, 12 };
            int[] dataB = { 8, 1, 2, 9, 3 };
            System.Console.WriteLine("dataA: " + Arrays.toString(dataA));
            System.Console.WriteLine("dataB: " + Arrays.toString(dataB));
            int[] union = Theorems.union(dataA, dataB);
            System.Console.WriteLine("union: " + Arrays.toString(union));
        }

        public static void testIntersect()
        {
            System.Console.WriteLine("# intersect");
            int[] dataA = { 2, 5, 3, 12 };
            int[] dataB = { 8, 1, 2, 9, 3 };
            System.Console.WriteLine("dataA: " + Arrays.toString(dataA));
            System.Console.WriteLine("dataB: " + Arrays.toString(dataB));
            int[] intersect = Theorems.intersect(dataA, dataB);
            System.Console.WriteLine("intersect: " + Arrays.toString(intersect));
        }

        public static void testRunUpSortedSet()
        {
            System.Console.WriteLine("# runUpSortedSet");
            int[] dataA = { 2, 3, 5, 12 };
            int[] dataB = { 1, 2, 3, 8, 9 };
            System.Console.WriteLine("dataA: " + Arrays.toString(dataA));
            System.Console.WriteLine("dataB: " + Arrays.toString(dataB));
            int[] runup = Theorems.runUpSortedSet(dataA, dataB);
            System.Console.WriteLine("runUpSortedSet: " + Arrays.toString(runup));
        }

        public static void testSimpleSwapSort()
        {
            System.Console.WriteLine("# simpleSwapSort");
            int[] data = { 10, 3, 8, 4, 5, 2 };
            System.Console.WriteLine("data: " + Arrays.toString(data));
            Theorems.simpleSwapSort(data);
            System.Console.WriteLine("simpleSwapSort: " + Arrays.toString(data));
        }

        public static void testMinimumSelectionSort()
        {
            System.Console.WriteLine("# minimumSelectionSort");
            int[] data = { 10, 3, 8, 4, 5, 2 };
            System.Console.WriteLine("data: " + Arrays.toString(data));
            Theorems.minimumSelectionSort(data);
            System.Console.WriteLine("minimumSelectionSort: " + Arrays.toString(data));
        }

        public static void testLinearSearch()
        {
            System.Console.WriteLine("# linearSearch (8)");
            int[] data = { 10, 3, 8, 4, 5, 2 };
            System.Console.WriteLine("data: " + Arrays.toString(data));
            int index = Theorems.linearSearch(data, 8);
            System.Console.WriteLine("index: " + index);
        }

        public static void testLinearSearchInSortedArray()
        {
            System.Console.WriteLine("# linearSearchInSortedArray (8)");
            int[] data = { 2, 3, 4, 5, 8, 10 };
            System.Console.WriteLine("data: " + Arrays.toString(data));
            int index = Theorems.linearSearchInSortedArray(data, 8);
            System.Console.WriteLine("index: " + index);
        }

        public static void testBinarySearch()
        {
            System.Console.WriteLine("# binarySearch (8)");
            int[] data = { 2, 3, 4, 5, 8, 10 };
            System.Console.WriteLine("data: " + Arrays.toString(data));
            int index = Theorems.binarySearch(data, 8);
            System.Console.WriteLine("index: " + index);
        }

    }
}
