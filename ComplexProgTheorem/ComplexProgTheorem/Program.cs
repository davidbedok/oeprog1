using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplexProgTheorem
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            Random rand = new Random();
            People iPeople = new People(rand);
            System.Console.WriteLine(iPeople);
            int manms = iPeople.getAllNumberOfMatchStick(SexType.Man);
            System.Console.WriteLine("Man's MatchStick: " + manms);
            int womanms = iPeople.getAllNumberOfMatchStick(SexType.Woman);
            System.Console.WriteLine("Woman's MatchStick: " + womanms);
            System.Console.WriteLine("HigherMatchStichFan: "+iPeople.getHigherMatchStickFan());
            System.Console.WriteLine("Difference: " + Math.Abs(manms - womanms));

            System.Console.WriteLine("MaxFamilyMatchStickCollection: " + iPeople.getMaxFamilyMatchStickCollection());
        }
    }
}
