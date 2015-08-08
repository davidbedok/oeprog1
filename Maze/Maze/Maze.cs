using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    public class Maze
    {
        private const char SEPARATOR = ';';
        private const char WALL = 'X';

        private readonly int left;
        private readonly int top;
        private readonly bool[,] fields;

        private int Width
        {
            get { return this.fields.GetLength(1); }
        }

        private int Height
        {
            get { return this.fields.GetLength(0); }
        }

        public int Left
        {
            get { return this.left; }
        }

        public int Top
        {
            get { return this.top; }
        }

        public Maze(int left, int top, int width, int height)
        {
            this.left = left;
            this.top = top;
            this.fields = new bool[height, width];
        }

        private void SetWall(int row, int column)
        {
            this.fields[row, column] = true;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int row = 0; row < this.Height; row++)
            {
                System.Console.SetCursorPosition(this.left, this.top + row);
                for (int column = 0; column < this.Width; column++)
                {
                    System.Console.Write(this.IsWall(row, column) ? WALL : ' ');
                }
            }
        }

        public bool IsWall(int row, int column)
        {
            return this.isValid(row, column) && this.fields[row, column];
        }

        private bool isValid(int row, int column)
        {
            return this.IsValidRow(row) && this.IsValidColumn(column);
        }

        private bool IsValidRow(int row)
        {
            return row >= 0 && row < this.Height;
        }

        private bool IsValidColumn(int column)
        {
            return column >= 0 && column < this.Width;
        }

        public Player CreatePlayer( Random random, ConsoleColor background )
        {
            int row = 0;
            int column = 0;
            do {
                row = random.Next(this.Height);
                column = random.Next(this.Width);
            } while (IsWall(row, column));
            return new Player(background, row, column);
        }

        public static Maze Load(int left, int top, String fileName)
        {
            StreamReader reader = new StreamReader(File.Open(fileName, FileMode.Open));
            Maze maze = CreateMaze(left, top, reader.ReadLine());
            String line = "";
            int row = 0;
            while ((line = reader.ReadLine()) != null)
            {
                for (int column = 0; column < line.Length; column++)
                {
                    if (line[column] == WALL)
                    {
                        maze.SetWall(row, column);
                    }
                }
                row++;
            }
            reader.Close();
            return maze;
        }

        private static Maze CreateMaze(int left, int top, String coordinateLine)
        {
            String[] coords = coordinateLine.Split(SEPARATOR);
            return new Maze(left, top, Int32.Parse(coords[0]), Int32.Parse(coords[1]));
        }

    }
}
