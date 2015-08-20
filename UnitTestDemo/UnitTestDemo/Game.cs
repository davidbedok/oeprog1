using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class Game
    {

        private const int SPECIAL_ROLL_VALUE = 6;

        private readonly Player player;
        private readonly Dice dice;

        public Player Player
        {
            get { return this.player; }
        }

        public Game(RandomWrapper random, int money)
        {
            this.player = new Player(money);
            this.dice = new Dice(random);
        }

        public void Play(int bet)
        {
            int firstRoll = this.dice.Roll();
            int secondRoll = this.dice.Roll();
            if (firstRoll == secondRoll)
            {
                if (firstRoll == SPECIAL_ROLL_VALUE)
                {
                    this.player.win(bet * 2);
                }
                else
                {
                    this.player.win(bet);
                }
            }
            else if (Math.Abs(firstRoll - secondRoll) > 1)
            {
                this.player.lose(bet);
            }
        }



    }
}
