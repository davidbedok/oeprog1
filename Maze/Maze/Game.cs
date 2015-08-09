using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Game
    {
        private static readonly ConsoleColor BACKGROUND = ConsoleColor.Gray;

        private readonly int left;
        private readonly int top;
        private readonly Maze maze;
        private readonly Player player;

        public Game(Random random, int left, int top, String mazeFileName)
        {
            this.left = left;
            this.top = top;
            this.maze = Maze.Load(left, top, mazeFileName);
            this.player = this.maze.CreatePlayer(random, BACKGROUND);
        }

        public void Play()
        {
            Console.BackgroundColor = BACKGROUND;
            Console.Clear();
            this.maze.Show();
            this.player.Move(this.maze, Direction.LEFT);
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        this.player.Move(this.maze, Direction.LEFT);
                        break;
                    case ConsoleKey.RightArrow:
                        this.player.Move(this.maze, Direction.RIGHT);
                        break;
                    case ConsoleKey.UpArrow:
                        this.player.Move(this.maze, Direction.UP);
                        break;
                    case ConsoleKey.DownArrow:
                        this.player.Move(this.maze, Direction.DOWN);
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }

    }
}
