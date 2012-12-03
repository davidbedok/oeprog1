using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHunCard
{
    public class Program
    {
        private static void testEnums()
        {
            Console.WriteLine("# test enums");
            CardRank cardRank = CardRank.King;
            Console.WriteLine("CardRank: " + cardRank);
            Console.WriteLine("Value: " + (int)cardRank);

            CardRank[] cardRanks = (CardRank[])Enum.GetValues(typeof(CardRank));
            for (int i = 0; i < cardRanks.Length; i++ )
            {
                Console.WriteLine(cardRanks[i]);
            }
        }

        private static void testCard()
        {
            Console.WriteLine("# testCard");
            Card card = new Card(CardRank.King, CardSuit.Hearts);
            Console.WriteLine(card);
        }

        private static void testDeck(Random rand)
        {
            Console.WriteLine("# testDeck");
            Deck deck = new Deck(rand);
            Console.WriteLine(deck);
            Console.WriteLine(deck.topCard());
            Console.WriteLine(deck.topCard());
            Console.WriteLine(deck.topCard());
            Console.WriteLine(deck);
            deck.rotate();
            Console.WriteLine(deck);
        }

        private static void testPlayer()
        {
            Console.WriteLine("# test Player");
            Player player = new Player("Nemecsek Erno");
            player.addCard(new Card(CardRank.King, CardSuit.Acorns));
            player.addCard(new Card(CardRank.r7, CardSuit.Hearts));
            player.addCard(new Card(CardRank.r8, CardSuit.Bells));
            Console.WriteLine(player);
        }

        private static void testGame(Random rand)
        {
            Console.WriteLine("# test Game");
            Game game = new Game(rand);
            game.addPlayer("Nemecserk Erno");
            game.addPlayer("Darth Vader");
            game.addPlayer("Anakin Skywalker");
            Console.WriteLine(game.newGame());
            Console.WriteLine(game.ToString());
        }

        private static void Main(string[] args)
        {
            Random rand = new Random();
            Program.testEnums();
            Program.testCard();
            Program.testDeck(rand);
            Program.testPlayer();
            Program.testGame(rand);
        }
    }
}
