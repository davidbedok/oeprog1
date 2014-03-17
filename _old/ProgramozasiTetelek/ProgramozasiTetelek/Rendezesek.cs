using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramozasiTetelek
{
    public class Rendezesek
    {

        private static void Csere(int[] array, int indexA, int indexB)
        {
            if ((array != null) && (indexA < array.Length) && (indexB < array.Length))
            {
                int tmp = array[indexA];
                array[indexA] = array[indexB];
                array[indexB] = tmp;
            }
        }

        private static void SpecCsere(int[] array, int indexA, int indexB)
        {
            //  int a=5,
            //  int b=10;
            //  a=a+b; // a = 15
            //  b=a-b; // b = 5
            //  a=a-b; // a = 10

            // de! ha tomb indexek vannak akkor figyelni kell, hogy ne legyen azonos a ket index! (mert ref-kent ugyanazt a mezot egy lepesben irjak kulonben)
            if ((array != null) && (indexA < array.Length) && (indexB < array.Length))
            {
                if (indexA != indexB)
                {
                    array[indexA] = array[indexA] + array[indexB];
                    array[indexB] = array[indexA] - array[indexB];
                    array[indexA] = array[indexA] - array[indexB];
                }
            }
        }

        private static void SpecCsereXOR(int[] array, int indexA, int indexB)
        {
            if ((array != null) && (indexA < array.Length) && (indexB < array.Length))
            {
                if (indexA != indexB)
                {
                    array[indexA] = array[indexA] ^ array[indexB];
                    array[indexB] = array[indexA] ^ array[indexB];
                    array[indexA] = array[indexA] ^ array[indexB];
                }
            }
        }

        public static void MinimumKivalasztasosRendezes(int[] array)
        {
            if ((array != null) && (array.Length > 0))
            {
                for (int i = 0; i < (array.Length - 1); i++)
                {
                    int min = array[i];
                    int minIndex = i;
                    for (int j = i; j < array.Length; j++)
                    {
                        if (min > array[j])
                        {
                            min = array[j];
                            minIndex = j;
                        }
                    }
                    Rendezesek.SpecCsereXOR(array, i, minIndex);
                }
            }
        }

    }
}
