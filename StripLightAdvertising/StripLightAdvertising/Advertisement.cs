using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace StripLightAdvertising
{
    public class Advertisement
    {

        private int actShift;
        private readonly CharacterModel[] adModel;
        private readonly ConsoleColor backgroundColor;

        public int AdvertisementWidth
        {
            get
            {
                return this.adModel.Length * CharacterData.CHAR_WIDTH + this.adModel.Length - 1;
            }
        }

        public int AdvertisementHeight
        {
            get
            {
                return CharacterData.CHAR_HEIGHT + 2;
            }
        }

        public Advertisement(string label, Random rand, ConsoleColor backgroundColor)
        {
            this.actShift = 0;
            this.adModel = new CharacterModel[label.Length];
            for (int i = 0; i < label.Length; i++)
            {
                this.adModel[i] = new CharacterModel(label[i], rand);    
            }
            this.backgroundColor = backgroundColor;
        }

        private void stepShiftForward()
        {
            if (this.actShift < this.AdvertisementWidth)
            {
                this.actShift++;
            }
            else
            {
                this.actShift = 0;
            }
        }

        private void stepShiftBack()
        {
            if (this.actShift > 0)
            {
                this.actShift--;
            }
            else
            {
                this.actShift = this.AdvertisementWidth;
            }
        }

        private static string shiftRow( string row, int shift )
        {
            return row.Substring(row.Length - shift, shift) + row.Substring(0, row.Length - shift);
        }

        public string print()
        {
            this.stepShiftBack();
            return this.print(this.actShift);
        }

        public string print(int shift)
        {
            StringBuilder sb = new StringBuilder();
            for (int k = 0; k < CharacterData.CHAR_HEIGHT; k++)
            {
                StringBuilder sbLine = new StringBuilder();
                for (int i = 0; i < this.adModel.Length; i++)
                {
                    sbLine.Append(this.adModel[i].getRow(k)).Append(" ");
                }
                sb.AppendLine(Advertisement.shiftRow(sbLine.ToString(), shift));
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.print(0);
        }

        public void play(ConsoleColor foregroundColor, int speed)
        {
            System.Console.WindowHeight = this.AdvertisementHeight;
            System.Console.WindowWidth = this.AdvertisementWidth + 2;
            System.Console.ForegroundColor = foregroundColor;
            System.Console.BackgroundColor = this.backgroundColor;
            System.Console.Clear();
            bool exitCycle = false;
            do
            {
                System.Console.SetCursorPosition(0, 0);
                System.Console.WriteLine(this.print());
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
