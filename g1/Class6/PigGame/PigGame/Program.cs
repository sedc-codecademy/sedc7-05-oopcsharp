using PigGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //PlayerTest player1 = new PlayerTest("","");
            //player1.FirstName = "Marjan";
            //player1.LastName = "Pushev";
            //Console.WriteLine($"Player FullName={player1.FullName()}");
            //Console.ReadLine();

            //Player player1 = new Player();
            //player1.FirstName = "Marjan";
            //player1.LastName = "Pushev";
            //Console.WriteLine($"Player FullName = {player1.FullName()}");

            //Dice dice1 = new Dice();
            //dice1.Color = Dice.Colors.White;
            //dice1.Size = Dice.Sizes.Low;

            //Dice dice2 = new Dice();
            //dice1.Color = Dice.Colors.Red;
            //dice1.Size = Dice.Sizes.Medium;

            //Console.WriteLine($"Dice1.Color = {dice1.Color}");



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Welcome to Pig Game");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine(
                "The game is played by two players.\n" +
                "The player who first gets to 50 points wins.\n" +
                "Each turn, player rolls 2 dice.\n" +
                "If at least one dice value is 1, player does not add the points and ends the turn.\n" +
                "If both dice values are greater than 1, player chooses to rolls again or adds points.");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.ResetColor();

            Console.WriteLine("1. New Game");
            Console.WriteLine("0. Exit");
            bool startingGame = true;
            while (startingGame)
            {
                bool isValidAction = int.TryParse(Console.ReadLine(), out int action);
                if (isValidAction)
                {
                    switch (action)
                    {
                        case 1:
                            Game game = new Game();
                            game.StartGame();
                            startingGame = false;
                            break;
                        case 0:
                            startingGame = false;
                            //Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter Valid Action !!!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enter Valid Action !!!");
                }
            }

            Console.ReadLine();
        }
    }
}
