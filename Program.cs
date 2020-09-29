using System;

namespace SnakeAndLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Snake and Ladder Simulator");
            int score;
            score = 0;
            Console.WriteLine("Initial score : " + score);

            score = DiceRoll();
            Console.WriteLine("DiceRoll " + score);

            return;
        }
        static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
    }
}
