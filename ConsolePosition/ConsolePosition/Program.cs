﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;


namespace ConsoleApplication10
{
    class Program
    {
        const int SWP_NOSIZE = 0x0001;


        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();

        private static IntPtr MyConsole = GetConsoleWindow();

        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

        static void Main(string[] args)
        {
            int xpos = 10;
            int ypos = 10;
            SetWindowPos(MyConsole, 0, xpos, ypos, 0, 0, SWP_NOSIZE);
            Console.WriteLine("any text");
            Console.Read();
        }
    }
}