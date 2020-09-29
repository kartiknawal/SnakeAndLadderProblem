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

            while (score != 100)
            {
                if (score < 0)
                    score = 0;

                int diceRoll;
                diceRoll = DiceRoll();
                Console.WriteLine("DiceRoll " + diceRoll);

                string option;
                option = CheckOptions();
                Console.WriteLine("The player got the option " + option);

                switch (option)
                {
                    case "NO_PLAY":
                        break;
                    case "LADDER":
                        score += diceRoll;
                        if (score > 100)
                            score -= diceRoll;
                        break;
                    case "SNAKE":
                        score -= diceRoll;
                        break;
                    default:
                        break;
                }

                Console.WriteLine("The score after the dice roll is " + score + "\n");
            }
            return;

        }
        static string CheckOptions()
        {
            string[] options = new string[3] { "NO_PLAY", "LADDER", "SNAKE" };
            int index;

            Random random = new Random();
            index = random.Next(0, 3);
            return options[index];
        }
        static int DiceRoll()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
    }
}
