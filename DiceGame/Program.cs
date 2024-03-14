using System;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            string answer;
            do
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Press enter to roll the dice.");
                    Console.ReadKey();

                    int playerRandomNum = random.Next(1, 9);
                    int enemyRandomNum = random.Next(1, 9);

                    Console.WriteLine("Player 1 rolled a " + playerRandomNum);
                    Console.WriteLine("...");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Player 2 rolled a " + enemyRandomNum);

                    if (playerRandomNum > enemyRandomNum)
                    {
                        playerPoints++;
                        Console.WriteLine("Player 1 wins this round");
                    }
                    else if (playerRandomNum < enemyRandomNum)
                    {
                        enemyPoints++;
                        Console.WriteLine("Player 2 wins this round");
                    }
                    else
                    {
                        Console.WriteLine("Draw!");
                    }

                    Console.WriteLine("The score is now - Player 1: {0}. Player 2: {1}.", playerPoints, enemyPoints);
                    Console.WriteLine("----------------------------------------------");
                }

                Console.Write("Do you want to play again? (yes/no): ");
                answer = Console.ReadLine().Trim().ToLower();

                while (answer != "yes" && answer != "no")
                {
                    Console.Write("Please enter 'yes' or 'no': ");
                    answer = Console.ReadLine().Trim().ToLower();
                }
            } while (answer == "yes");

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("Player 1 wins the game!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("Player 2 wins the game!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.ReadKey();
        }
    }
}
