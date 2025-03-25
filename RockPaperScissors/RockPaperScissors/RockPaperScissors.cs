namespace RockPaperScissors;

class RockPaperScissors
{
    static void Main(string[] args)
    {
        // Creates three constants for our "Rock", "Paper" and "Scissors"
        const string Rock = "Rock";
        const string Paper = "Paper";
        const string Scissors = "Scissors";

        while (true)
        {
            // The program first checks for correct input (move)
            try
            {
                Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
                string playerMove = Console.ReadLine();

                // checks if the input (move) is incorrect trow exception message
                if (playerMove != "r" && playerMove != "rock"
                    && playerMove != "p" && playerMove != "paper"
                    && playerMove != "s" && playerMove != "scissors")
                {
                    throw new ArgumentException("Invalid input.");
                }
                
                // If the input (move) is valid, we continue with the logic
                // Defining player's move
                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }

                //Defining random move for the computer
                Random random = new Random();
                int randomNumber = random.Next(1, 4);
                
                string computerMove = string.Empty;
                switch (randomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;
                    case 2:
                        computerMove = Paper;
                        break;
                    case 3:
                        computerMove = Scissors;
                        break;
                }

                Console.WriteLine($"The computer chose {computerMove}.");

                // Every case of wining, losing and draw for the player
                if ((playerMove == Rock && computerMove == Scissors)
                    || (playerMove == Paper && computerMove == Rock)
                    || (playerMove == Scissors && computerMove == Paper))
                {
                    Console.WriteLine("You win.");
                }
                else if ((playerMove == Rock && computerMove == Paper)
                         || (playerMove == Paper && computerMove == Scissors)
                         || (playerMove == Scissors && computerMove == Rock))
                {
                    Console.WriteLine("You lose.");
                }
                else // Both the player and the computer used the same object (e.g. playerMove == Paper && computerMove == Paper) etc
                {
                    Console.WriteLine("This game was a draw.");
                }
                
                break;
            }
            // If the input (move) is incorrect, we try again. 
            catch (ArgumentException exception)
            {
                Console.WriteLine($"{exception.Message} Try again...");
            }
        }
    }
}
