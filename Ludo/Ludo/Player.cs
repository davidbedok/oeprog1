using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo
{
    public class Player
    {

        private const int NUMBER_OF_FIGURES = 4;

        private readonly String name;
        private readonly FigureColor color;
        private readonly int startPosition;

        private int numOfFiguresAtStart;
        private int numOfFiguresAtFinish;
        private int numOfHits;
        private int numOfDeaths;
        private int winningRound;

        public String Name
        {
            get { return this.name; }
        }

        public char Sign
        {
            get { return this.color.Sign; }
        }

        public int StartPosition
        {
            get { return this.startPosition; }
        }

        public int WinningRound
        {
            get { return this.winningRound; }
        }

        public Player(String name, FigureColor color, int startPosition)
        {
            this.name = name;
            this.color = color;
            this.startPosition = startPosition;

            this.numOfFiguresAtStart = NUMBER_OF_FIGURES;
            this.numOfFiguresAtFinish = 0;

            this.numOfHits = 0;
            this.numOfDeaths = 0;
            this.winningRound = -1;
        }

        public Figure Start()
        {
            if (this.numOfFiguresAtStart > 0)
            {
                this.numOfFiguresAtStart--;
            }
            return new Figure(this);
        }

        public bool HasFigureAtStart()
        {
            return this.numOfFiguresAtStart > 0;
        }

        public void Finish()
        {
            if (this.numOfFiguresAtFinish < NUMBER_OF_FIGURES)
            {
                this.numOfFiguresAtFinish++;
            }
        }

        public void Hit()
        {
            this.numOfHits++;
        }

        public void Death()
        {
            if (this.numOfFiguresAtStart < NUMBER_OF_FIGURES)
            {
                this.numOfFiguresAtStart++;
                this.numOfDeaths++;
            }
        }

        public bool IsFinish()
        {
            return this.numOfFiguresAtFinish == NUMBER_OF_FIGURES;
        }

        public void End(int round)
        {
            this.winningRound = round;
        }

        public String PrintStartFigure(int index)
        {
            return "(" + this.PrintFigure(index, this.numOfFiguresAtStart) + ")";
        }

        public String PrintFinishFigure(int index)
        {
            return " " + this.PrintFigure(index, this.numOfFiguresAtFinish) + " ";
        }

        private char PrintFigure(int index, int numOfFigures)
        {
            return numOfFigures >= index + 1 ? this.Sign : ' ';
        }

        public override String ToString()
        {
            return this.name + " (" + this.Sign + ") Hit: " + this.numOfHits + " Death: " + this.numOfDeaths;
        }

    }
}
