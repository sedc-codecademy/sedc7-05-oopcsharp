using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigGame.Models
{
    class Game
    {
        private readonly int winningScore = 50;
        private Random rnd;

        int activePlayer = 0;
        int tempScore = 0;
        bool gameIsActive = false;

        private Player[] players = new Player[2];
        private Dice[] dice2 = new Dice[2];
        
        public void StartGame()
        {
            this.rnd = new Random();
            this.gameIsActive = true;
            this.CreatePlayers();
            this.CreateDice();
            this.SetStartingPlayer();
            
            int turn = 0;
            while(gameIsActive)
            {
                this.PrintPlayerScores(turn);

                Console.Write($"{players[activePlayer].FullName()}: 1. Roll 2.Hold: ");
                bool isValidSelection = int.TryParse(Console.ReadLine(), out int action);

                if (isValidSelection)
                {
                    switch (action)
                    {
                        case 1:
                            this.Roll();
                            break;
                        case 2:
                            this.Hold();
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
                turn++;
            }

            Console.WriteLine($"Winner is {players[activePlayer].FullName()} score = {players[activePlayer].Score}");
        }

        private void CreatePlayers()
        {
            for (int i = 0; i < players.Length; i++)
            {
                Console.Write($"Player{i} First Name: ");
                string firstName = Console.ReadLine();
                Console.Write($"Player{i} Last Name: ");
                string lastName = Console.ReadLine();
                players[i] = new Player();
                players[i].FirstName = firstName;
                players[i].LastName = lastName;
            }
        }
        private void CreateDice()
        {
            dice2[0] = new Dice(this.rnd);
            dice2[0].Size = Dice.Sizes.Medium;
            dice2[0].Color = Dice.Colors.Red;

            dice2[1] = new Dice(this.rnd);
            dice2[1].Size = Dice.Sizes.Medium;
            dice2[1].Color = Dice.Colors.Blue;
            
            //for (int i = 0; i < dice2.Length; i++)
            //{
            //    dice2[i] = new Dice(rnd);
            //    dice2[i].Size = Dice.Sizes.Medium;
            //    dice2[i].Color = Dice.Colors.White;
            //}
        }

        private void SetStartingPlayer()
        {
            activePlayer = this.rnd.Next(0, 2);
        }
        private void ChangeActivePlayer()
        {
            activePlayer++;
            activePlayer = activePlayer % players.Length;
        }
        private void PrintPlayerScores(int turn)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine($"Score - turn {turn}");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            for (int i = 0; i < players.Length; i++)
            {
                if (activePlayer == i)
                {
                    Console.WriteLine($"{players[i].FullName()} score = {players[i].Score} tempScore = {tempScore}");
                }
                else
                {
                    Console.WriteLine($"{players[i].FullName()} score = {players[i].Score}");
                }
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.ResetColor();
        }

        private void Roll()
        {
            bool diceIsOne = false;
            Console.Write($"{players[activePlayer].FullName()}: ");
            for (int i = 0; i < dice2.Length; i++)
            {
                dice2[i].Roll();

                switch (dice2[i].Color)
                {
                    case Dice.Colors.White:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Dice.Colors.Red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Dice.Colors.Blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    default:
                        break;
                }
                Console.Write($"Dice{i} = {dice2[i].Value} ");
                Console.ResetColor();

                tempScore += dice2[i].Value;
                if (dice2[i].Value == 1)
                {
                    diceIsOne = true; ;
                }
            }
            if (diceIsOne)
            {
                tempScore = 0;
                this.ChangeActivePlayer();
            }
        }
        private void Hold()
        {
            players[activePlayer].Score += tempScore;
            tempScore = 0;
            if (players[activePlayer].Score >= winningScore)
            {
                gameIsActive = false;
            }
            else
            {
                this.ChangeActivePlayer();
            }
        }
    }
}
