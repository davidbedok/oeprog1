using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    public class Player
    {

        private int money;

        public int Money
        {
            get { return this.money; }
        }

        public Player(int money)
        {
            this.money = money;
        }

        public void Pay(int bet)
        {
            this.money -= bet;
        }

        public void Win(int amount)
        {
            this.money += amount;
        }

        public void Lose(int amount)
        {
            this.money -= amount;
            if (this.money < 0)
            {
                throw new NotEnoughMoneyException();
            }
        }

    }
}
