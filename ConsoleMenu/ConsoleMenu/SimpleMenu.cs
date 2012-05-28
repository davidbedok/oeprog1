using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMenu
{
    public class SimpleMenu
    {

        private int top;
        private int left;
        private string[] menuItems;
        private int menuIndex;
        private int activeMenuIndex;
        private ConsoleColor bgrColor;
        private ConsoleColor menuItemColor;
        private ConsoleColor activeMenuBgr;

        private int Top
        {
            set
            {
                if (value > 0)
                {
                    this.top = value;
                }
            }
        }

        private int Left
        {
            set
            {
                if (value > 0)
                {
                    this.left = value;
                }
            }
        }

        public ConsoleColor MenuItemColor
        {
            get { return this.menuItemColor; }
            set { this.menuItemColor = value; }
        }

        public ConsoleColor ActiveMenuBgr
        {
            get { return this.activeMenuBgr; }
            set { this.activeMenuBgr = value; }
        }

        public SimpleMenu(int top, int left, int maxMenuItem, ConsoleColor bgrColor)
        {
            if (maxMenuItem < 1)
            {
                maxMenuItem = 1;
            }
            this.Top = top;
            this.Left = left;
            this.menuItems = new string[maxMenuItem];
            this.menuIndex = 0;
            this.bgrColor = bgrColor;
            this.activeMenuIndex = 0;
            this.menuItemColor = ConsoleColor.White;
            this.activeMenuBgr = ConsoleColor.Yellow;
        }

        public void addMenuItem(string label)
        {
            if (this.menuIndex < this.menuItems.Length)
            {
                this.menuItems[this.menuIndex++] = label;
            }
        }

        public void down()
        {
            if (this.activeMenuIndex < this.menuIndex - 1)
            {
                this.activeMenuIndex++;
            }
            else
            {
                this.activeMenuIndex = 0;
            }
        }

        public void up()
        {
            if (this.activeMenuIndex > 0)
            {
                this.activeMenuIndex--;
            }
            else
            {
                this.activeMenuIndex = this.menuIndex - 1;
            }
        }

        private int getMaxMenuItemLength()
        {
            int ret = 0;
            if ( this.menuIndex > 0 ) {
                ret = this.menuItems[0].Length;
                for (int i = 1; i < this.menuIndex; i++)
                {
                    if (ret < this.menuItems[i].Length)
                    {
                        ret = this.menuItems[i].Length;
                    }
                }
            }
            return ret;
        }

        private void drawMenuTop(int maxLength)
        {
            System.Console.SetCursorPosition(this.left, this.top);
            System.Console.WriteLine("╔" + "".PadLeft(maxLength, '═') + "╗");
        }

        private void drawMenuMiddle(int maxLength, int row)
        {
            System.Console.SetCursorPosition(this.left, this.top + row);
            System.Console.WriteLine("╠" + "".PadLeft(maxLength, '═') + "╣");
        }

        private void drawMenuBottom(int maxLength, int row)
        {
            System.Console.SetCursorPosition(this.left, this.top + row);
            System.Console.WriteLine("╚" + "".PadLeft(maxLength, '═') + "╝");
        }

        private void setMenuItemBgr( int i ){
            if (i == this.activeMenuIndex)
            {
                System.Console.BackgroundColor = this.activeMenuBgr;
            }
            else
            {
                System.Console.BackgroundColor = this.bgrColor;
            }
        }

        public void draw()
        {
            System.Console.ForegroundColor = this.menuItemColor;
            System.Console.BackgroundColor = this.bgrColor;
            int maxLength = this.getMaxMenuItemLength();

            this.drawMenuTop(maxLength);

            int row = 0;
            for (int i = 0; i < this.menuIndex; i++)
            {
                System.Console.SetCursorPosition(this.left, this.top + ++row);
                System.Console.BackgroundColor = this.bgrColor;
                System.Console.Write("│");
                this.setMenuItemBgr(i);
                System.Console.Write(this.menuItems[i].PadRight(maxLength, ' '));
                System.Console.BackgroundColor = this.bgrColor;
                System.Console.Write("│");

                if (i != this.menuIndex - 1)
                {
                    this.drawMenuMiddle(maxLength, ++row);
                }
            }
            this.drawMenuBottom(maxLength, ++row);
        }

        public int process()
        {
            ConsoleKey cKey;
            do
            {
                this.draw();
                cKey = Console.ReadKey(true).Key;
                switch (cKey)
                {
                    case ConsoleKey.UpArrow:
                        this.up();
                        break;
                    case ConsoleKey.DownArrow:
                        this.down();
                        break;
                }
            } while ((cKey != ConsoleKey.Escape) && (cKey != ConsoleKey.Enter));
            return this.activeMenuIndex;
        }

        private string getMenuLabelByIndex(int index){
            string ret = "";
            if (index < this.menuIndex)
            {
                ret = this.menuItems[index];
            }
            return ret;
        }

        public string getActiveMenuLabel()
        {
            return this.getMenuLabelByIndex(this.activeMenuIndex);
        }


    }
}
