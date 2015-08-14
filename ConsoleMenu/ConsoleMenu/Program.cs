using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleMenu
{
    public class Program
    {

        private static readonly int WINDOW_WIDTH = 70;
        private static readonly int WINDOW_HEIGHT = 25;

        private static void Main(string[] args)
        {
            TestSimpleMenu();
        }

        private static void TestSimpleMenu()
        {
            DrawFrame();

            SimpleMenu menu = new SimpleMenu(5, 5);
            menu.Add(10, "Lorem");
            menu.Add(20, "Ipsum");
            menu.Add(30, "Dolor sit");
            menu.Add(40, "Exit");

            MenuTemplate template = new MenuTemplate(ConsoleColor.Gray, ConsoleColor.Black, ConsoleColor.Yellow, ConsoleColor.DarkRed);
            SimpleMenu childMenu = new SimpleMenu(9, 14, template);
            childMenu.Add(31, "Consectetur");
            childMenu.Add(32, "Adipiscing");
            childMenu.Add(33, "Back");

            MenuItem item;
            do {
                item = menu.Process();
                switch (item.Id)
                {
                    case 10:
                    case 20:
                        Program.WriteMessage(1,1,item.Label);
                        break;
                    case 30:
                        MenuItem childItem;
                        do {
                            childItem = childMenu.Process();
                            switch (childItem.Id)
                            {
                                case 31:
                                case 32:
                                    Program.WriteMessage(1, 1, childItem.Label);
                                    break;
                            }
                        } while (childItem.Id != 33);
                        break;
                }

            } while (item.Id != 40);
        }

        private static void DrawFrame()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.SetWindowSize(Program.WINDOW_WIDTH, Program.WINDOW_HEIGHT);
            Console.Title = "Simple Console Menu Demo";
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
            Console.Write(" Simple Console Menu Demo Application @ UNI-OBUDA 2015".PadRight(Program.WINDOW_WIDTH));
            Console.BackgroundColor = ConsoleColor.Gray;
        }

        private static void WriteMessage(int x, int y, string label)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(x, y);
            Console.Write(label.PadRight(30));
        }

    }
}
