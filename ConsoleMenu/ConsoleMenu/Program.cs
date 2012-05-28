using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMenu
{
    public class Program
    {

        private static readonly int WINDOW_WIDTH = 100;
        private static readonly int WINDOW_HEIGHT = 40;

        private const string MENUITEM_TEST = "Test menupoint";
        private const string MENUITEM_DUMMY = "Dummy menupoint";
        private const string MENUITEM_CHILDMENU = "Child menu";
        private const string MENUITEM_BACK = "Back";
        private const string MENUITEM_EXIT = "Exit";

        private static void writeMessage( int x, int y, string label)
        {
            System.Console.BackgroundColor = ConsoleColor.Gray;
            System.Console.ForegroundColor = ConsoleColor.Black;
            System.Console.SetCursorPosition(x, y);
            System.Console.Write(label.PadRight(30));
        }

        private static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.SetWindowSize(Program.WINDOW_WIDTH, Program.WINDOW_HEIGHT);
            Console.Title = "Simple Console Menu Demo";
            System.Console.BackgroundColor = ConsoleColor.Red;
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.SetCursorPosition(0,0);
            System.Console.Write(" Simple Console Menu Demo Application @ UNI-OBUDA 2011".PadRight(Program.WINDOW_WIDTH));
            System.Console.BackgroundColor = ConsoleColor.Gray;

            SimpleMenu menu = new SimpleMenu(5, 5, 5, ConsoleColor.Blue);
            menu.MenuItemColor = ConsoleColor.Black;
            menu.ActiveMenuBgr = ConsoleColor.Yellow;
            menu.addMenuItem(Program.MENUITEM_TEST);
            menu.addMenuItem(Program.MENUITEM_DUMMY);
            menu.addMenuItem(Program.MENUITEM_CHILDMENU);
            menu.addMenuItem(Program.MENUITEM_EXIT);

            SimpleMenu childMenu = new SimpleMenu(9, 14, 5, ConsoleColor.Gray);
            childMenu.MenuItemColor = ConsoleColor.Black;
            childMenu.ActiveMenuBgr = ConsoleColor.Yellow;
            childMenu.addMenuItem(Program.MENUITEM_TEST);
            childMenu.addMenuItem(Program.MENUITEM_DUMMY);
            childMenu.addMenuItem(Program.MENUITEM_BACK);

            int menuIndex;
            do {
                menuIndex = menu.process();
                switch (menu.getActiveMenuLabel())
                {
                    case Program.MENUITEM_TEST:
                        Program.writeMessage(1,1,Program.MENUITEM_TEST);
                        break;
                    case Program.MENUITEM_DUMMY:
                        Program.writeMessage(1, 1, Program.MENUITEM_DUMMY);
                        break;
                    case Program.MENUITEM_CHILDMENU:

                        int childMenuIndex;
                        do {
                            childMenuIndex = childMenu.process();
                            switch (childMenu.getActiveMenuLabel())
                            {
                                case Program.MENUITEM_TEST:
                                    Program.writeMessage(1, 1, Program.MENUITEM_TEST);
                                    break;
                                case Program.MENUITEM_DUMMY:
                                    Program.writeMessage(1, 1, Program.MENUITEM_DUMMY);
                                    break;
                            }
                        } while (!childMenu.getActiveMenuLabel().Equals(Program.MENUITEM_BACK));
                        break;
                }

            } while (!menu.getActiveMenuLabel().Equals(Program.MENUITEM_EXIT));

        }
    }
}
