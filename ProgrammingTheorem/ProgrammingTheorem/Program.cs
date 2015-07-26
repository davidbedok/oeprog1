using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingTheorem
{

    public class Program
    {

        private static void Main2(string[] args)
        {
            System.Console.WriteLine("ProgrammingTheorem Demo");   

            TheoremsTest.testSummation();
            TheoremsTest.testDecisionDivisible();
            TheoremsTest.testSelectionDivisible();
            TheoremsTest.testCountingDivisible();
            TheoremsTest.testMaximumSelection();
            TheoremsTest.testAssortmentDivisible();
            TheoremsTest.testAssortmentMinimums();
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
