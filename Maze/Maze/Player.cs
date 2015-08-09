using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Player
    {
        private const char SHAPE = '@';

        private readonly ConsoleColor background;
        private int row;
        private int column;

        public Player(ConsoleColor background, int row, int column)
        {
            this.background = background;
            this.row = row;
            this.column = column;
        }

        public void Move(Maze maze, Direction direction)
        {
            this.Draw(this.background, maze.Left, maze.Top);
            switch (direction)
            {
                case Direction.LEFT:
                    if (!maze.IsWall(this.row, this.column - 1))
                    {
                        this.column--;
                    }
                    break;
                case Direction.RIGHT:
                    if (!maze.IsWall(this.row, this.column + 1))
                    {
                        this.column++;
                    }
                    break;
                case Direction.UP:
                    if (!maze.IsWall(this.row - 1, this.column))
                    {
                        this.row--;
                    }
                    break;
                case Direction.DOWN:
                    if (!maze.IsWall(this.row + 1, this.column))
                    {
                        this.row++;
                    }
                    break;
            }
            this.Draw(ConsoleColor.Green, maze.Left, maze.Top);
        }

        private void Draw(ConsoleColor color, int left, int top)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(left + this.column, top + this.row);
            Console.Write(SHAPE);
        }

    }
}
