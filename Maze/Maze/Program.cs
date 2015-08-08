using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Program
    {
        private static readonly int WINDOW_WIDTH = 36;
        private static readonly int WINDOW_HEIGHT = 16;

        private static void Main(string[] args)
        {
            Console.SetWindowSize(Program.WINDOW_WIDTH, Program.WINDOW_HEIGHT);
            Console.Title = "Maze";

            Game game = new Game(new Random(), 3, 2, @"maze\track-1.txt");
            game.Play();
        }
    }
}
