using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMenu
{
    public class Position
    {
        private readonly int top;
        private readonly int left;

        public Position(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public void SetCursor(int row)
        {
            Console.SetCursorPosition(this.left, this.top + row);
        }

    }
}
