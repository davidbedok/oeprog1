using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramozasiTetelek
{
    public class SorozathozSorozatot
    {
        // masolas tetele
        public static int[] Duplazas( int[] array )
        {
            int[] ret = null;
            if (array != null)
            {
                ret = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    ret[i] = array[i] * 2;
                }
            }
            return ret;
        }

        public static int[] ParosElemekKivalogatasa(int[] array)
        {
            int[] ret = null;
            if (array != null)
            {
                ret = new int[SorozathozErteket.ParosElemekMegszamlalasa(array)];
                if (ret.Length > 0)
                {
                    int j = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            ret[j++] = array[i];
                        }
                    }
                }
            }
            return ret;
        }

        public static int[] ParitasSzerintiSzetvalogatas(int[] array)
        {
            int[] ret = null;
            if (array != null)
            {
                ret = new int[array.Length];
                
                int start = 0;
                int end = ret.Length;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        ret[start++] = array[i];
                    }
                    else
                    {
                        ret[--end] = array[i];
                    }
                }
                
            }
            return ret;
        }

        public static int[] KetHalmazMetszete(int[] arrayA, int[] arrayB)
        {
            int[] tmp = new int[Math.Min(arrayA.Length, arrayB.Length)];
            int index = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                int j = 0;
                while ((j < arrayB.Length) && (arrayA[i] != arrayB[j])){
                    ++j;
                }
                if (j < arrayB.Length)
                {
                    tmp[index++] = arrayA[i];
                }
            }
            int[] ret = new int[index];
            for (int i = 0; i < index; i++ )
            {
                ret[i] = tmp[i];
            }
            return ret;
        }

        public static int[] KetHalmazUnioja(int[] arrayA, int[] arrayB)
        {
            int[] tmp = new int[(arrayA.Length + arrayB.Length)];
            int index = 0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                tmp[index++] = arrayA[i];
            }
            for (int i = 0; i < arrayB.Length; i++)
            {
                int j = 0;
                while ((j < arrayA.Length) && (arrayB[i] != arrayA[j]))
                {
                    ++j;
                }
                if (j == arrayA.Length)
                {
                    tmp[index++] = arrayB[i];
                }
            }
            int[] ret = new int[index];
            for (int i = 0; i < index; i++)
            {
                ret[i] = tmp[i];
            }
            return ret;
        }

    }
}
