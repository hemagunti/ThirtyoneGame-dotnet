using System;
using System.IO;
using ThirtyOne.Helpers;
using ThirtyOne.Models;

namespace ThirtyOne
{
    class Program
    {
        private static string filename;
        private static string text;

        static void Main(string[] args)
        {
            //Initial test
            Deck deck = new Deck();
            deck.Initialize();
            Random randomNumberGenerator = new Random();
            deck.Shuffle(randomNumberGenerator);
            Card card = deck.DrawCard();

            //Game implementation
            Console.WriteLine("Let's play 31!");
            ComputerPlayer computerPlayer = new ComputerPlayer("Computer");
            Game game = new Game(randomNumberGenerator, computerPlayer, new ConsolePlayer("You"));
            bool isGameOver = false;
            while (!isGameOver)
            {
                File.WriteAllText("myGame.json", game.SerializeGame());
                Console.WriteLine($"{game.CurrentPlayer.Name} turn!");
                isGameOver = game.NextTurn();
                Console.WriteLine($"{computerPlayer.Name} {computerPlayer.LastAction}");

            }

            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine($"--- GAME OVER, {game.Winner.Name} WON WITH {game.Winner.Hand.ToListString()} ---");
            Console.ReadLine();
        }
    }
}
