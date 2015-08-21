using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            Game game = new Game(new RandomWrapper(random), 1000);
            int numberOfParties = 0;
            try
            {
                while (true)
                {
                    numberOfParties++;
                    game.Play(random.Next(70) + 30);
                    Console.WriteLine("Money: " + game.Player.Money);
                }

            }
            catch (NotEnoughMoneyException e)
            {
                Console.WriteLine("Player loses all of his money within " + numberOfParties + " parties.");
            }
        }
    }
}
