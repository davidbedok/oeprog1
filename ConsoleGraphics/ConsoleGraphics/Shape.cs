using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleGraphics
{
    public class Shape
    {
        private readonly int width;
        private readonly int height;
        private readonly ConsoleColor bgrColor;

        private int positionX;
        private int positionY;
        private ConsoleColor color;
        private char shape;

        // private
        public int PositionX
        {
            get
            {
                return this.positionX;
            }
            set
            {
                if ((value >= 0) && (value < this.width))
                {
                    this.positionX = value;
                }
            }
        }

        public int PositionY
        {
            get
            {
                return this.positionY;
            }
            set
            {
                if ((value >= 0) && (value < this.height))
                {
                    this.positionY = value;
                }
            }
        }

        public Shape(int width, int height, ConsoleColor bgrColor, ConsoleColor color, char shape)
        {
            this.width = width;
            this.height = height;
            this.bgrColor = bgrColor;
            this.color = color;
            this.PositionX = width / 2; // this.positionX = width / 2;
            this.PositionY = height / 2;
            this.shape = shape;
        }
   
        public void draw()
        {
            this.draw(this.color);
        }

        public void erase()
        {
            this.draw(this.bgrColor);
        }

        private void draw( ConsoleColor color )
        {
            System.Console.ForegroundColor = color;
            System.Console.SetCursorPosition(this.positionX, this.positionY);
            System.Console.Write(this.shape);
        }

        public void left()
        {
            this.move(MoveType.LEFT);
        }

        public void right()
        {
            this.move(MoveType.RIGHT);
        }

        public void up()
        {
            this.move(MoveType.UP);
        }

        public void down()
        {
            this.move(MoveType.DOWN);
        }

        public void move(MoveType moveType)
        {
            this.erase();
            switch (moveType)
            {
                case MoveType.LEFT:
                    this.PositionX = this.positionX - 1;
                    break;
                case MoveType.RIGHT:
                    this.PositionX = this.positionX + 1;
                    break;
                case MoveType.UP:
                    this.PositionY = this.positionY - 1;
                    break;
                case MoveType.DOWN:
                    this.PositionY = this.positionY + 1;
                    break;
            }
            this.draw();
        }

        public override string ToString()
        {
            return "Shape ["+this.positionX+":"+this.positionY+"]";
        }

    }
}
