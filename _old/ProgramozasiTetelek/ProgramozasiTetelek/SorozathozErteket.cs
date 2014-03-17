using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramozasiTetelek
{
    // a felev kesobbi reszen ezen statikus metodusok gyujtemenye generikus eszkozokkel tovabb altalanosithato
    public class SorozathozErteket
    {
        // adott elemeig osszegzi a tombot
        public static int Osszegzes( int[] array, int N )
        {
            int ret = 0;
            if ((array != null) && (array.Length >= N))
            {
                for (int i = 0; i < N; i++)
                {
                    ret += array[i];
                }
            }
            return ret;
        }

        // a tomb minden elemet osszegzi
        public static int Osszegzes(int[] array)
        {
            return ( array != null ? SorozathozErteket.Osszegzes(array,array.Length) : 0);
        }

        // eldonti, hogy van e megadott elem a tomb egeszeben
        public static bool Eldontes(int[] array, int value)
        {
            bool ret = false;
            if (array != null)
            {
                int i = 0;
                while ((i < array.Length) && (!ret))
                {
                    ret = (array[i] == value);
                    i++;
                }
            }
            return ret;
        }

        // kivalasztja az elso olyan elemet, melynek erteke a megadott, es visszaadja sorszamat (ha nincs elem, -1-et ad vissza)
        public static int LinearisKereses(int[] array, int value)
        {
            bool find = false;
            int i = 0;
            if (array != null)
            {
                while ((i < array.Length) && (!find))
                {
                    find = (array[i] == value);
                    i++;
                }
            }
            return (find?(i-1):-1);
        }

        // megszamolja, mennyi megadott erteku elem van a tombben
        public static int Megszamlalas(int[] array, int value)
        {
            int ret = 0;
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        ++ret;
                    }
                } 
            }
            return ret;
        }

        public static int ParosElemekMegszamlalasa(int[] array)
        {
            int ret = 0;
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        ++ret;
                    }
                }
            }
            return ret;
        }

        // visszaadja az elso maximalis elem indexet
        public static int MaximumKivalasztas(int[] array)
        {
            int ret = -1;
            if ((array != null) && (array.Length > 0))
            {
                int max = array[0];
                ret = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        ret = i;
                    }
                }
            }
            return ret;
        }

    }
}
