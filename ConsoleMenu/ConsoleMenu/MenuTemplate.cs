using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMenu
{
    public class MenuTemplate
    {

        private readonly ConsoleColor backgroundColor;
        private readonly ConsoleColor itemColor;
        private readonly ConsoleColor highlightedBackgroundColor;
        private readonly ConsoleColor highlightedItemColor;

        public ConsoleColor BackgroundColor
        {
            get { return this.backgroundColor; }
        }

        public ConsoleColor ItemColor
        {
            get { return this.itemColor; }
        }

        public ConsoleColor HighlightedBackgroundColor
        {
            get { return this.highlightedBackgroundColor; }
        }

        public ConsoleColor HighlightedItemColor
        {
            get { return this.highlightedItemColor; }
        }

        public MenuTemplate(ConsoleColor backgroundColor, ConsoleColor itemColor, ConsoleColor selectedBackgroundColor, ConsoleColor selectedItemColor)
        {
            this.backgroundColor = backgroundColor;
            this.itemColor = itemColor;
            this.highlightedBackgroundColor = selectedBackgroundColor;
            this.highlightedItemColor = selectedItemColor;
        }

        public void SetNormalColors()
        {
            Console.BackgroundColor = this.backgroundColor;
            Console.ForegroundColor = this.itemColor;
        }

        public void SetHighlightedColors()
        {
            Console.BackgroundColor = this.highlightedBackgroundColor;
            Console.ForegroundColor = this.highlightedItemColor;
        }

    }
}
