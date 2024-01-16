using System;

namespace Rockpaperscissorgame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissor Game!");
            Console.WriteLine("Press 'Enter' to begin...");
            Console.ReadLine();
            Console.Clear();
            Play();
        }
        // This will assist the gamer in looking excellent as they proceed to the following page.
        public static void Play()
        {
            while (true)
            {
                Console.WriteLine("Enter your move: (r for Rock, p for Paper, or s for Scissors)");
                string PlayerMove = Console.ReadLine().ToLower(); //  This will convert input to lowercase.

                // This will check whether user entered valid inut or not.
                if (PlayerMove != "r" && PlayerMove != "p" && PlayerMove != "s")
                {
                    Console.WriteLine("Invalid move. Please try again.");
                    continue;
                }

                string CompMove = GetCompMove();
                Console.WriteLine("Computer's move: " + CompMove);

                string result = Win(PlayerMove, CompMove);
                Console.WriteLine(result);

                // This will ask user whether he/she wants to play again or not.
                Console.WriteLine("Do you want to play again? (yes or no)");
                string playAgain = Console.ReadLine().ToLower(); // This will convert input to lowercase.

                if (playAgain != "yes")
                    break;
            }
            Console.WriteLine("Thank you for playing the game!");
        }

        public static string GetCompMove()
        {
            // This will create random value from r, p and s.
            string[] moves = { "r", "p", "s" };
            Random random = new Random();
            int randomNumber = random.Next(moves.Length);

            return moves[randomNumber];
        }

        public static string Win(string PlayerMove, string CompMove)
        {
            // Final result will be shown here. Whether it's a tie or palyer wins or computer wins.
            if (PlayerMove == CompMove)
            {
                return "It's a tie!";
            }
            else if (PlayerMove == "r")
            {
                return CompMove == "s" ? "Congratulations, You Win!" : "You Lose and Computer Wins!";
            }
            else if (PlayerMove == "p")
            {
                return CompMove == "r" ? "Congratulations, You Win!" : "You Lose and Computer Wins!";
            }
            else if (PlayerMove == "s")
            {
                return CompMove == "p" ? "Congratulations, You Win!" : "You Lose and Computer Wins!";
            }
            else
            {
                return "Invalid input! Please try again.";
            }
        }
    }
}
