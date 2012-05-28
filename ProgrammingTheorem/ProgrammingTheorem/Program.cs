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

        private static string printArrayFunction(int[] data)
        {
            StringBuilder sb = new StringBuilder(50);
            sb.Append("Array: ");
            foreach (int item in data)
            {
                sb.Append(item).Append(" ");
            }
            sb.Append("\n");
            return sb.ToString();
        }

        private static int getMinValueFromArray( int[] data )
        {
            int ret = -1;
            if (data.Length > 0)
            {
                ret = data[0];
                /*
                int i = 1;
                while ( i < data.Length){
                    if (ret > data[i])
                    {
                        ret = data[i];
                    }
                    i++;
                }
                */
                for (int i = 1; i < data.Length; i++ )
                {
                    if (ret > data[i])
                    {
                        ret = data[i];
                    }
                }
            }
            return ret;
        }

        private static int countItem(int[] data, int item)
        {
            int count = 0;
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] == item)
                {
                    ++count;
                }
            }
            return count;
        }

        private static int[] getMinPositionsFromArray( int[] data )
        {
            int[] ret = null;
            int min = Program.getMinValueFromArray(data);
            if (min != -1)
            {
                ret = new int[Program.countItem(data, min)];
                /*
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == min)
                    {
                        ret[tmp++] = j;
                    }
                }
                */
                int tmp = 0;
                int j = 0;
                while (( j < data.Length ) && (tmp < ret.Length) ){
                    if (data[j] == min)
                    {
                        ret[tmp++] = j;
                    }
                    j++;
                }
            }
            return ret;
        }

        private static void switchItems(int[] data, int aPos, int bPos)
        {
            int tmp = data[aPos];
            data[aPos] = data[bPos];
            data[bPos] = tmp;
        }

        private static void minimumSelectionSort(int[] data)
        {
            if (data.Length > 0)
            {
                int min;
                int minPos;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    min = data[i];
                    minPos = i;
                    for (int j = i; j < data.Length; j++)
                    {
                        if (min > data[j])
                        {
                            min = data[j];
                            minPos = j;
                        }
                    }
                    Program.switchItems(data, i, minPos);
                }
            }
        }

        private static void Main(string[] args)
        {
            System.Console.WriteLine("ProgrammingTheorem Demo");   
            /*
            int[] testArray;
            testArray = new int[5];
            testArray[0] = 42;
            testArray[1] = 30;
            testArray[2] = 10;
            testArray[3] = 34;
            testArray[4] = 67;
            Program.getMinValueFromArray(testArray);*/

            int[] testArray = { 42, 30, 10, 34, 67, 10, 753 };
            Program.printArray(testArray);
            System.Console.WriteLine(Program.printArrayFunction(testArray));
            // System.Console.WriteLine("Min value: " + Program.getMinValueFromArray(new int[]{42, 30, 10, 34, 67}) );
            System.Console.WriteLine("Min value: " + Program.getMinValueFromArray(testArray));

            int[] minPositions = Program.getMinPositionsFromArray(testArray);
            if (minPositions != null)
            {
                for (int i = 0; i < minPositions.Length; i++)
                {
                    System.Console.Write("Index of min. value: " + minPositions[i]);
                    System.Console.WriteLine(" (minimum value: " + testArray[minPositions[i]] + ")");
                }
            }
            
            Program.minimumSelectionSort(testArray);
            System.Console.WriteLine("\nAfter sort:");
            System.Console.WriteLine(Program.printArrayFunction(testArray));
        }
    }
}
