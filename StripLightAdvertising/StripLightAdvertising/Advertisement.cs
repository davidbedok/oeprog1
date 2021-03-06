﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StripLightAdvertising
{
    public class Advertisement
    {

        private const char LETTER_SEPARATOR = ' ';

        private int shift;
        private readonly CharacterModel[] models;
        private readonly int width;
        
        private int Width
        {
            get
            {
                return this.width;
            }
        }
        public int Height
        {
            get
            {
                return CharacterData.HEIGHT;
            }
        }

        public Advertisement(String label)
        {
            this.shift = 0;
            this.models = new CharacterModel[label.Length];
            int width = 0;
            for (int i = 0; i < label.Length; i++)
            {
                this.models[i] = new CharacterModel(label[i]);
                width += this.models[i].Width + 1;
            }
            this.width = width - 1;
        }

        public void StepForward()
        {
            if (this.shift < this.Width)
            {
                this.shift++;
            }
            else
            {
                this.shift = 0;
            }
        }

        public void StepBack()
        {
            if (this.shift > 0)
            {
                this.shift--;
            }
            else
            {
                this.shift = this.Width;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int k = 0; k < CharacterData.HEIGHT; k++)
            {
                StringBuilder line = new StringBuilder();
                for (int i = 0; i < this.models.Length; i++)
                {
                    line.Append(this.models[i].GetRow(k)).Append(LETTER_SEPARATOR);
                }
                builder.AppendLine(ShiftLine(line.ToString()));
            }
            return builder.ToString();
        }

        private string ShiftLine(string line)
        {
            return line.Substring(line.Length - this.shift, this.shift) + line.Substring(0, line.Length - this.shift);
        }

        public void Play(ConsoleColor backgroundColor, ConsoleColor foregroundColor, int speed)
        {
            Console.WindowHeight = this.Height + 2;
            Console.WindowWidth = this.Width + 2;
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;
            Console.Clear();
            bool exitCycle = false;
            do
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(this.ToString());
                // this.StepBack();
                this.StepForward();
                if (Console.KeyAvailable)
                {
                    exitCycle = (Console.ReadKey(true).Key == ConsoleKey.Escape);
                }
                else
                {
                    Thread.Sleep(speed);
                }
            } while (!exitCycle);
        }

    }
}
