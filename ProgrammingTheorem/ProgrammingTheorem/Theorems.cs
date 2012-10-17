using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammingTheorem
{
    public class Theorems
    {

        public static int summation(int[] data)
        {
            int result = 0;
            for (int i = 0; i < data.Length; i++)
            {
                result += data[i];
            }
            return result;
        }

        public static bool decisionDivisible(int[] data, int divider)
        {
            int i = 0;
            while ((i < data.Length) && (data[i] % divider != 0))
            {
                i++;
            }
            return (i < data.Length);
        }

        public static int selectionDivisible(int[] data, int divider)
        {
            int i = 0;
            while (data[i] % divider != 0)
            {
                i++;
            }
            return i;
        }

        public static int countingDivisible(int[] data, int divider)
        {
            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % divider == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int countingItem(int[] data, int item)
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

        public static int maximumSelection(int[] data)
        {
            int maximum = -1;
            if (data.Length > 0)
            {
                maximum = data[0];
                for (int i = 1; i < data.Length; i++)
                {
                    if (maximum < data[i])
                    {
                        maximum = data[i];
                    }
                }
            }
            return maximum;
        }

        public static int minimumSelection(int[] data)
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

        public static int[] assortmentDivisible(int[] data, int divider)
        {
            int numberOfDivisibleItem = Theorems.countingDivisible(data, divider);
            int[] divisibleData = new int[numberOfDivisibleItem];
            int index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % divider == 0)
                {
                    divisibleData[index++] = data[i];
                }
            }
            return divisibleData;
        }

        public static int[] assortmentMinimums(int[] data)
        {
            int[] mins = null;
            int min = Theorems.minimumSelection(data);
            if (min != -1)
            {
                int count = Theorems.countingItem(data, min);
                mins = new int[count];
                int index = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    if (min == data[i])
                    {
                        mins[index++] = i;
                    }
                }
            }
            return mins;
        }

        public static int[] assortmentMinimumsAlter(int[] data)
        {
            int[] mins = null;
            int[] minAndCount = Theorems.minimumSelectionAndCounting(data);
            if (minAndCount[0] != -1)
            {
                mins = new int[minAndCount[1]];
                int index = 0;
                int i = 0;
                while ( index < mins.Length )
                {
                    if (minAndCount[0] == data[i])
                    {
                        mins[index++] = i;
                    }
                    i++;
                }
            }
            return mins;
        }

        private static int[] minimumSelectionAndCounting(int[] data)
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

        public static int[][] separateParity(int[] data)
        {
            int[][] separateNumbers = new int[2][];
            int numberOfEvenNumbers = Theorems.countingDivisible(data, 2);
            separateNumbers[0] = new int[numberOfEvenNumbers];
            separateNumbers[1] = new int[data.Length - numberOfEvenNumbers];
            int enIndex = 0;
            int onIndex = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    separateNumbers[0][enIndex++] = data[i];
                }
                else
                {
                    separateNumbers[1][onIndex++] = data[i];
                }
            }
            return separateNumbers;
        }

        public static int[] union(int[] dataA, int[] dataB)
        {
            int[] union = new int[dataA.Length + dataB.Length];
            int index = 0;
            for (int i = 0; i < dataA.Length; i++)
            {
                union[index++] = dataA[i];
            }
            for (int i = 0; i < dataB.Length; i++)
            {
                int j = 0;
                while ((j < dataA.Length) && (dataB[i] != dataA[j]))
                {
                    j++;
                }
                if (j == dataA.Length)
                {
                    union[index++] = dataB[i];
                }
            }
            return Theorems.cropping(union, index);
        }

        private static int[] cropping(int[] source, int length)
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

        public static int[] intersect(int[] dataA, int[] dataB)
        {
            int[] intersect = new int[Math.Max(dataA.Length,dataB.Length)];
            int index = 0;
            for (int j = 0; j < dataA.Length; j++)
            {
                int i = 0;
                while ((i < dataB.Length) && (dataB[i] != dataA[j]))
                {
                    i++;
                }
                if (i < dataB.Length)
                {
                    intersect[index++] = dataA[j];
                }
            }
            return Theorems.cropping(intersect, index);
        }

        public static int[] runUpSortedSet(int[] dataA, int[] dataB)
        {
            int[] merge = new int[dataA.Length + dataB.Length];
            int index = 0;
            int i = 0;
            int j = 0;
            while ((i < dataB.Length) && (j < dataA.Length))
            {
                if (dataA[j] < dataB[i])
                {
                    merge[index++] = dataA[j];
                    j++;
                }
                else if (dataA[j] > dataB[i])
                {
                    merge[index++] = dataB[i];
                    i++;
                }
                else
                {
                    merge[index++] = dataA[j];
                    j++;
                    i++;
                }
            }
            while (i < dataB.Length)
            {
                merge[index++] = dataB[i];
                i++;
            }
            while (j < dataA.Length)
            {
                merge[index++] = dataA[j];
                j++;
            }
            return Theorems.cropping(merge, index);
        }

        public static void simpleSwapSort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i] > data[j])
                    {
                        Theorems.swap(data, i, j);
                    }
                }
            }
        }

        private static void swap(int[] data, int indexA, int indexB)
        {
            int tmp = data[indexA];
            data[indexA] = data[indexB];
            data[indexB] = tmp;
        }

        public static void minimumSelectionSort(int[] data)
        {
            if (data.Length > 0)
            {
                int minPos;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    minPos = i;
                    for (int j = i; j < data.Length; j++)
                    {
                        if (data[minPos] > data[j])
                        {
                            minPos = j;
                        }
                    }
                    Theorems.swap(data, i, minPos);
                }
            }
        }

        public static int linearSearch(int[] data, int element)
        {
            int index = -1;
            int i = 0;
            while ((i < data.Length) && (data[i] != element))
            {
                i++;
            }
            if (i < data.Length)
            {
                index = i;
            }
            return index;
        }

        public static int linearSearchInSortedArray(int[] data, int element)
        {
            int index = -1;
            int i = 0;
            while ((i < data.Length) && (data[i] < element))
            {
                i++;
            }
            if ((i < data.Length) && (data[i] == element))
            {
                index = i;
            }
            return index;
        }

        public static int binarySearch(int[] data, int element)
        {
            int lower = 0;
            int upper = data.Length - 1;
            int index = -1;
            while ((index == -1) && (lower <= upper))
            {
                int i = (lower + upper) / 2;
                if (data[i] == element)
                {
                    index = i;
                }
                else if (data[i] < element)
                {
                    lower = i + 1;
                }
                else
                {
                    upper = i - 1;
                }
            }
            return index;
        }

    }
}
