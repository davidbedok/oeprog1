using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StampCatalog
{
    public class Program
    {
        private static void Main(string[] args)
        {

            StampCatalog catalog = new StampCatalog();
            catalog.add("Hegyi gyopar", "Viragok", 1976, 27, 18, EdgeType.Fogazott, 5, 6.4);
            catalog.add("Parlament", null, 1987, 31, 28, EdgeType.ReszbenFogazott, 18, 3.2);
            catalog.add("Munkacsy", "Festok", 1992, 52, 35, EdgeType.Vagott, 36, 1.5);
            catalog.add("Hovirag", "Viragok", 1977, 27, 18, EdgeType.Fogazott, 7, 5.7);
            catalog.add("Neumann", null, 2003, 40, 27, EdgeType.Fogazott, 120, 1.9);

            Console.WriteLine(catalog);

            Console.WriteLine("# Total catalog value: " + catalog.getTotalCatalogValue()); 
            Console.WriteLine("# Total area of 'Viragok' series: " + catalog.getTotalArea("Viragok"));

            Console.WriteLine("\n# List of 'Fogazott' stamps: ");
            Stamp[] selectedStamps =  catalog.getStamps(EdgeType.Fogazott);
            for (int i = 0; i < selectedStamps.Length; i++)
            {
                Console.WriteLine(selectedStamps[i]);
            }

            Console.WriteLine("\n# Name of precious stamps: ");
            String[] preciousStamps = catalog.getPreciousStampNames();
            for (int i = 0; i < preciousStamps.Length; i++)
            {
                Console.WriteLine(preciousStamps[i]);
            }

            Console.ReadKey();

        }
    }
}
