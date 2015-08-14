using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMenu
{
    public class SimpleMenu
    {
        private static readonly MenuTemplate DEFAULT_TEMPLATE = new MenuTemplate(ConsoleColor.Blue, ConsoleColor.White, ConsoleColor.Yellow, ConsoleColor.DarkRed);
        private static readonly int MAXIMUM_MENU_ITEMS = 10;

        private readonly MenuTemplate template;
        private readonly int top;
        private readonly int left;
        private readonly MenuItem[] items;
        private int index;
        private int current;

        public SimpleMenu(int top, int left)
            : this(top, left, DEFAULT_TEMPLATE)
        {
        }

        public SimpleMenu(int top, int left, MenuTemplate template)
            : this(top, left, template, MAXIMUM_MENU_ITEMS)
        {

        }

        public SimpleMenu(int top, int left, MenuTemplate template, int maxMenuItem)
        {
            this.top = top;
            this.left = left;
            this.template = template;
            this.items = new MenuItem[maxMenuItem];
            this.index = 0;
            this.current = 0;
        }

        public void Add(int id, String label)
        {
            if (this.index < this.items.Length)
            {
                this.items[this.index++] = new MenuItem(id, label);
            }
        }

        public MenuItem Process()
        {
            ConsoleKey key;
            do
            {
                this.Draw();
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        this.Up();
                        break;
                    case ConsoleKey.DownArrow:
                        this.Down();
                        break;
                }
            } while ((key != ConsoleKey.Escape) && (key != ConsoleKey.Enter));
            return this.items[this.current];
        }

        private void Draw()
        {
            this.template.SetNormalColors();
            int maxLength = this.GetTheLargestLength() + 2;

            this.DrawTop(maxLength);
            int row = 0;
            for (int i = 0; i < this.index; i++)
            {
                this.DrawMenuItem(maxLength, i, ++row);
                if (i != this.index - 1)
                {
                    this.DrawMiddle(maxLength, ++row);
                }
            }
            this.DrawBottom(maxLength, ++row);
        }

        private int GetTheLargestLength()
        {
            int ret = 0;
            if (this.index > 0)
            {
                ret = this.items[0].Length;
                for (int i = 1; i < this.index; i++)
                {
                    int current = this.items[i].Length;
                    if (ret < current)
                    {
                        ret = current;
                    }
                }
            }
            return ret;
        }

        private void DrawTop(int maxLength)
        {
            Console.SetCursorPosition(this.left, this.top);
            Console.WriteLine("╔" + "".PadLeft(maxLength, '═') + "╗");
        }

        private void DrawMenuItem(int maxLength, int index, int row)
        {
            Console.SetCursorPosition(this.left, this.top + row);
            this.template.SetNormalColors();
            Console.Write("│");
            this.SetColors(index);
            Console.Write(" " + this.items[index].Label.PadRight(maxLength - 1, ' '));
            this.template.SetNormalColors();
            Console.Write("│");
        }

        private void SetColors(int index)
        {
            if (index == this.current)
            {
                this.template.SetHighlightedColors();
            }
            else
            {
                this.template.SetNormalColors();
            }
        }

        private void DrawMiddle(int maxLength, int row)
        {
            Console.SetCursorPosition(this.left, this.top + row);
            Console.WriteLine("╠" + "".PadLeft(maxLength, '═') + "╣");
        }

        private void DrawBottom(int maxLength, int row)
        {
            Console.SetCursorPosition(this.left, this.top + row);
            Console.WriteLine("╚" + "".PadLeft(maxLength, '═') + "╝");
        }

        private void Down()
        {
            this.current = this.current < this.index - 1 ? this.current + 1 : 0;
        }

        private void Up()
        {
            this.current = this.current > 0 ? this.current - 1 : this.index - 1;
        }

    }
}
