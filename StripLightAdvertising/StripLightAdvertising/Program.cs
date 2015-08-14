using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StripLightAdvertising
{
    public class Program
    {

        private static void Main(string[] args)
        {
            System.Console.Title = "Strip Light Advertising";
            Random random = new Random();
            // TestCharacterModel(random);
            // TestAdvertisement();
            TestAdvertisementMotion();
        }

        private static void TestCharacterModel(Random random)
        {
            CharacterModel a = new CharacterModel('A');
            Console.WriteLine(a);
            Console.WriteLine(a.GetRow(0));
            Console.WriteLine(a.GetRow(1));
            Console.WriteLine(a.GetRow(2));
            CharacterModel b = new CharacterModel('B');
            Console.WriteLine(b);
            CharacterModel c = new CharacterModel('C');
            Console.WriteLine(c);
            CharacterModel randomModel = CharacterModel.BuildRandomModel(random, 3, 6);
            Console.WriteLine(randomModel);
        }

        private static void TestAdvertisement()
        {
            Advertisement ad = new Advertisement("OBUDAI EGYETEM");
            Console.WriteLine(ad);
            ad.StepBack();
            ad.StepBack();
            ad.StepBack();
            Console.WriteLine(ad);
        }

        private static void TestAdvertisementMotion()
        {
            Advertisement ad = new Advertisement("OBUDAI EGYETEM ");
            ad.Play(ConsoleColor.White, ConsoleColor.DarkBlue, 100);
        }

    }
}
