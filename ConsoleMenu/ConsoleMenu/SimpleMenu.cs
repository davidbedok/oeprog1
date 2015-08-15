using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMenu
{
    public class SimpleMenu
    {
        private static readonly int MAXIMUM_MENU_ITEMS = 10;

        private readonly MenuTemplate template;
        private readonly Position position;
        private readonly MenuItem[] items;
        private int index;
        private int current;

        public SimpleMenu(int top, int left)
            : this(top, left, MenuTemplate.DEFAULT_TEMPLATE)
        {
        }

        public SimpleMenu(int top, int left, MenuTemplate template)
            : this(top, left, template, MAXIMUM_MENU_ITEMS)
        {

        }

        public SimpleMenu(int top, int left, MenuTemplate template, int maxMenuItem)
        {
            this.position = new Position(top, left);
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
            } while (key != ConsoleKey.Enter);
            return this.items[this.current];
        }

        private void Down()
        {
            this.current = this.current < this.index - 1 ? this.current + 1 : 0;
        }

        private void Up()
        {
            this.current = this.current > 0 ? this.current - 1 : this.index - 1;
        }

        private void Draw()
        {
            this.template.Normal.SetColors();
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
            this.position.SetCursor(0);
            Console.WriteLine("O" + "".PadLeft(maxLength, '-') + "O");
        }

        private void DrawMenuItem(int maxLength, int index, int row)
        {
            this.position.SetCursor(row);
            this.template.Normal.SetColors();
            Console.Write("|");
            this.SetColors(index);
            Console.Write(" " + this.items[index].Label.PadRight(maxLength - 1, ' '));
            this.template.Normal.SetColors();
            Console.Write("|");
        }

        private void SetColors(int index)
        {
            (index == this.current ? this.template.Highlighted : this.template.Normal).SetColors();
        }

        private void DrawMiddle(int maxLength, int row)
        {
            this.position.SetCursor(row);
            Console.WriteLine("O" + "".PadLeft(maxLength, '-') + "O");
        }

        private void DrawBottom(int maxLength, int row)
        {
            this.position.SetCursor(row);
            Console.WriteLine("O" + "".PadLeft(maxLength, '-') + "O");
        }


    }
}
