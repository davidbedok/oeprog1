using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleGraphics
{
    public class Program
    {
        private static readonly int WINDOW_WIDTH = 70;
        private static readonly int WINDOW_HEIGHT = 40;

        private static ConsoleColor getRandomConsoleColor(Random rand)
        {
            // inclusive lower, exclusive upper bound
            byte num = (byte)rand.Next(0, 16);
            return (ConsoleColor)num;
        }

        private static char getRandomShape(Random rand)
        {
            int num = rand.Next(40, 90);
            return (char)num;
        }

        private static MoveType getRandomMove(Random rand)
        {
            byte num = (byte)rand.Next(0, 4);
            return (MoveType)num;
        }

        private static void Main(string[] args)
        {
            Random rand = new Random();

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            
            Console.SetWindowSize(Program.WINDOW_WIDTH, Program.WINDOW_HEIGHT);
            Console.Title = "Console Graphics Demo";

            Shape iShape = new Shape(Console.WindowWidth, Console.WindowHeight, Console.BackgroundColor, ConsoleColor.Red, '@');
            iShape.draw();
            ConsoleKey cKey;
            do {
                cKey = Console.ReadKey(true).Key;
                switch (cKey)
                {
                    case ConsoleKey.LeftArrow:
                        iShape.left();
                        break;
                    case ConsoleKey.RightArrow:
                        iShape.right();
                        break;
                    case ConsoleKey.UpArrow:
                        iShape.up();
                        break;
                    case ConsoleKey.DownArrow:
                        iShape.down();
                        break;
                    default:
                        // Console.WriteLine(cKey);
                        break;
                }
            } while (cKey != ConsoleKey.Escape);

            Shape[] shapes = new Shape[10];
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i] = new Shape(Console.WindowWidth, Console.WindowHeight, Console.BackgroundColor, Program.getRandomConsoleColor(rand), Program.getRandomShape(rand));
            }

            bool exitCycle = false;
            do {
                
                for (int i = 0; i < shapes.Length; i++)
                {
                    shapes[i].move(Program.getRandomMove(rand));
                }

                if (Console.KeyAvailable)
                {
                    exitCycle = (Console.ReadKey(true).Key == ConsoleKey.Escape);
                }
            } while (!exitCycle);
            
        }
    }
}
