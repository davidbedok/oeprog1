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
            System.Console.WriteLine("# List of CardSuit");
            CardSuit[] listOfCardSuit = (CardSuit[])Enum.GetValues(typeof(CardSuit));
            for (int i = 0; i < listOfCardSuit.Length; i++)
            {
                System.Console.Write(listOfCardSuit[i] + " ");
            }
            System.Console.WriteLine();
        }

        private static void testCardClass(Random rand)
        {
            System.Console.WriteLine("# Test Card class");
            Card cardInstance = new Card(CardSuit.Acorns, CardRank.r8);
            System.Console.WriteLine(cardInstance);

            Card randomCard = Card.getRandomCard(rand);
            System.Console.WriteLine(randomCard);
        }

        private static void testDeckClass(Random rand)
        {
            System.Console.WriteLine("# Test Deck class");
            Deck deckInstance = new Deck(rand);
            System.Console.WriteLine(deckInstance);
            deckInstance.rotate();
            System.Console.WriteLine(deckInstance);
            System.Console.WriteLine(deckInstance.getTopCard());
            System.Console.WriteLine(deckInstance.getTopCard());
            System.Console.WriteLine(deckInstance.getTopCard());
        }

        private static void testPlayerClass(Random rand)
        {
            System.Console.WriteLine("# Test Player class");
            Card cardInstance = new Card(CardSuit.Acorns, CardRank.r8);
            System.Console.WriteLine(cardInstance);

            Player playerInstance = new Player("Teszt Elek");

            // without indexer
            playerInstance.setCardsItem(0, cardInstance);
            playerInstance.setCardsItem(1, Card.getRandomCard(rand));
            playerInstance.setCardsItem(2, new Card(CardSuit.Bells, CardRank.r10));

            // with indexer
            playerInstance[0] = cardInstance;
            playerInstance[1] = Card.getRandomCard(rand);
            playerInstance[2] = new Card(CardSuit.Bells, CardRank.r10);

            // for game
            playerInstance.addCard(cardInstance);
            playerInstance.addCard(Card.getRandomCard(rand));
            playerInstance.addCard(CardSuit.Bells, CardRank.r10);

            System.Console.WriteLine(playerInstance);
        }

        private static void testGame(Random rand)
        {
            System.Console.WriteLine("# Test Game class");
            Game hunCardGame = new Game(rand, 4);
            hunCardGame.addPlayer("Teszt Elek");
            hunCardGame.addPlayer(new Player("Nemecsek Erno"));
            hunCardGame.addPlayer("Jancsi Esjuliska");
            hunCardGame.addPlayer("Vitez Janos");
            hunCardGame.addPlayer("No More");

            System.Console.WriteLine("------ WINNER ------");
            System.Console.WriteLine(hunCardGame.newGame());
            System.Console.WriteLine("------ GAME ------");
            System.Console.WriteLine(hunCardGame);

            System.Console.WriteLine("------ Third Player Second Card ------");
            System.Console.WriteLine(hunCardGame[2][1]);
        }

        private static void Main(string[] args)
        {
            Random rand = new Random();
            // Program.testCardSuitEnum();
            // Program.testCardClass(rand);
            // Program.testDeckClass(rand);
            // Program.testPlayerClass(rand);
            Program.testGame(rand);
        }
    }

}
