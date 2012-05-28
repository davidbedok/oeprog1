using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StripLightAdvertising
{
    public class Program
    {

        private static void testCharacterModel(Random rand)
        {
            CharacterModel modelA = new CharacterModel('A', rand);
            System.Console.WriteLine(modelA);
            System.Console.WriteLine(modelA.getRow(0));
            System.Console.WriteLine(modelA.getRow(1));
            System.Console.WriteLine(modelA.getRow(2));
            CharacterModel modelB = new CharacterModel('B', rand);
            System.Console.WriteLine(modelB);
            CharacterModel modelC = new CharacterModel('C', rand);
            System.Console.WriteLine(modelC);
            CharacterModel modelRand = new CharacterModel('R', rand);
            System.Console.WriteLine(modelRand);
        }

        private static void testAdvertisement(Random rand)
        {
            Advertisement ad = new Advertisement("ABCRAABBRRA", rand, ConsoleColor.Black);
            System.Console.WriteLine(ad);
        }

        private static void testMoveAd(Random rand)
        {
            Advertisement ad = new Advertisement("OBUDAI EGYETEM ", rand, ConsoleColor.Yellow);
            ad.play(ConsoleColor.Black, 100);
        }

        private static void Main(string[] args)
        {
            System.Console.Title = "Strip Light Advertising";
            Random rand = new Random();
            // Program.testCharacterModel(rand);
            // Program.testAdvertisement(rand);
            Program.testMoveAd(rand);
        }
    }
}
