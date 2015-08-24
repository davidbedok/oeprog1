using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HunCard.CardEnum;

namespace HunCard.Test
{
    public class Program
    {
        private static void testCardSuitEnum()
        {
            Console.WriteLine("# List of CardSuit");
            CardSuit[] listOfCardSuit = (CardSuit[])Enum.GetValues(typeof(CardSuit));
            for (int i = 0; i < listOfCardSuit.Length; i++)
            {
                Console.Write(listOfCardSuit[i] + " ");
            }
            Console.WriteLine();
        }

        private static void TestCardClass(Random rand)
        {
            Console.WriteLine("# Test Card class");
            Card card = new Card(CardSuit.Acorns, CardRank.r8);
            Console.WriteLine(card);

            Card randomCard = Card.GetRandomCard(rand);
            Console.WriteLine(randomCard);
        }

        private static void TestDeckClass(Random rand)
        {
            Console.WriteLine("# Test Deck class");
            Deck deck = new Deck(rand);
            Console.WriteLine(deck);
            deck.Rotate();
            Console.WriteLine(deck);
            Console.WriteLine(deck.GetTopCard());
            Console.WriteLine(deck.GetTopCard());
            Console.WriteLine(deck.GetTopCard());
        }

        private static void TestPlayerClass(Random rand)
        {
            Console.WriteLine("# Test Player class");
            Card card = new Card(CardSuit.Acorns, CardRank.r8);
            Console.WriteLine(card);

            Player player = new Player("Teszt Elek");

            // without indexer
            player.SetCard(0, card);
            player.SetCard(1, Card.GetRandomCard(rand));
            player.SetCard(2, new Card(CardSuit.Bells, CardRank.r10));

            // with indexer
            player[0] = card;
            player[1] = Card.GetRandomCard(rand);
            player[2] = new Card(CardSuit.Bells, CardRank.r10);

            // for game
            player.AddCard(card);
            player.AddCard(Card.GetRandomCard(rand));
            player.AddCard(CardSuit.Bells, CardRank.r10);

            Console.WriteLine(player);
        }

        private static void TestGame(Random rand)
        {
            Console.WriteLine("# Test Game class");
            Game game = new Game(rand, 4);
            game.AddPlayer("Teszt Elek");
            game.AddPlayer(new Player("Nemecsek Erno"));
            game.AddPlayer("Jancsi Esjuliska");
            game.AddPlayer("Vitez Janos");
            game.AddPlayer("No More");

            Console.WriteLine("------ WINNER ------");
            Console.WriteLine(game.NewGame());
            Console.WriteLine("------ GAME ------");
            Console.WriteLine(game);

            Console.WriteLine("------ Third Player Second Card ------");
            Console.WriteLine(game[2][1]);
        }

        private static void Main(string[] args)
        {
            Random rand = new Random();
            // Program.TestCardSuitEnum();
            // Program.TestCardClass(rand);
            // Program.TestDeckClass(rand);
            // Program.TestPlayerClass(rand);
            Program.TestGame(rand);
        }
    }

}
