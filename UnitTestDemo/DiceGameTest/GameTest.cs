using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;

namespace DiceGameTest
{

    [TestClass]
    public class GameTest
    {

        private const int SPECIAL_ROLL_VALUE = 6;

        [TestMethod]
        public void Player_loses_money_when_the_rolled_numbers_are_far_away()
        {


            FakeRandomWrapper random = new FakeRandomWrapper(1, 3);
            Game game = new Game(random, 1000);
            game.Play(300);
            Assert.AreEqual(700, game.Player.Money);
        }

        [TestMethod]
        public void Player_does_not_lose_money_when_the_rolled_numbers_are_not_far_away()
        {
            FakeRandomWrapper random = new FakeRandomWrapper(2, 3);
            Game game = new Game(random, 1000);
            game.Play(300);
            Assert.AreEqual(1000, game.Player.Money);
        }

        [TestMethod]
        public void Player_wins_money_when_the_rolled_numbers_are_equals_but_not_special()
        {
            FakeRandomWrapper random = new FakeRandomWrapper(4, 4);
            Game game = new Game(random, 1000);
            game.Play(300);
            Assert.AreEqual(1300, game.Player.Money);
        }

        [TestMethod]
        public void Player_wins_double_money_when_the_rolled_numbers_are_equals_and_special()
        {
            FakeRandomWrapper random = new FakeRandomWrapper(SPECIAL_ROLL_VALUE, SPECIAL_ROLL_VALUE);
            Game game = new Game(random, 1000);
            game.Play(300);
            Assert.AreEqual(1600, game.Player.Money);
        }

        [TestMethod]
        [ExpectedException(typeof(NotEnoughMoneyException))]
        public void Throw_NotEnoughMoneyException_when_player_loses_all_of_his_money()
        {
            FakeRandomWrapper random = new FakeRandomWrapper(1, 6, 2, 5);
            Game game = new Game(random, 1000);
            game.Play(600);
            Assert.AreEqual(400, game.Player.Money);
            game.Play(600);
            Assert.Fail();
        }

    }
}
