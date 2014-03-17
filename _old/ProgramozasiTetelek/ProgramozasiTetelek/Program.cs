using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramozasiTetelek
{
    // kivetelesen ez az alkalmazas sok elnevezese magyar nyelvu
    public class Program
    {

        public static string PrintArray(int[] array)
        {
            StringBuilder sb = new StringBuilder(300);
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    sb.Append("["+i+"] "+array[i]+"\n");
                }
            }
            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            int[] array = { 10, 13, 20, 17, 30, 40, 10 };
            System.Console.WriteLine(Program.PrintArray(array));
            int osszeg = SorozathozErteket.Osszegzes(array);
            System.Console.WriteLine("Osszeg: "+osszeg);
            bool van = SorozathozErteket.Eldontes(array, 30);
            System.Console.WriteLine("Van 30? " + (van?"igen":"nem"));
            int index = SorozathozErteket.LinearisKereses(array, 30);
            System.Console.WriteLine("30 index: " + index);
            int db = SorozathozErteket.Megszamlalas(array, 10);
            System.Console.WriteLine("10 darab: " + db);
            int maxIndex = SorozathozErteket.MaximumKivalasztas(array);
            System.Console.WriteLine("Max ertek: " + (maxIndex!=-1? array[maxIndex].ToString() : "nincs"));
            System.Console.WriteLine(Program.PrintArray(SorozathozSorozatot.Duplazas(array)));
            System.Console.WriteLine("Paros elemek:\n"+Program.PrintArray(SorozathozSorozatot.ParosElemekKivalogatasa(array)));
            System.Console.WriteLine("Paritasos szetvalogatas:\n" + Program.PrintArray(SorozathozSorozatot.ParitasSzerintiSzetvalogatas(array)));

            System.Console.WriteLine("Metszet:\n" + Program.PrintArray(SorozathozSorozatot.KetHalmazMetszete(new int[]{5,2,6,4,1,3},new int[]{8,4,9,6,7,3,5})));
            System.Console.WriteLine("Unio:\n" + Program.PrintArray(SorozathozSorozatot.KetHalmazUnioja(new int[] { 5, 2, 6, 4, 1, 3 }, new int[] { 8, 4, 9, 6, 7, 3, 5 })));

            Rendezesek.MinimumKivalasztasosRendezes(array);
            System.Console.WriteLine("Rendezett halmaz:\n" + Program.PrintArray(array));

        }
    }
}
