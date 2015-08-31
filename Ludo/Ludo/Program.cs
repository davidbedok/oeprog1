using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ludo
{
    class Program
    {
        static void Main(string[] args)
        {
            GameSimulation(new Random());
        }

        private static void GameSimulation(Random random)
        {
            Game game = new Game(random);
            game.AddPlayers("Alice", "Bob", "Charlie", "Delta");

            while (!game.IsFinish())
            {
                Console.Clear();
                Console.WriteLine(game.Step());
                Console.WriteLine(game);
                // Console.ReadKey();
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine(game.PrintPalpitating());
            Console.ReadKey();
        }


    }
}
