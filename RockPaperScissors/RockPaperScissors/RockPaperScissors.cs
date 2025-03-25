namespace RockPaperScissors;

class RockPaperScissors
{
    static void Main(string[] args)
    {
        // Creates three constants for our "Rock", "Paper" and "Scissors"
        const string Rock = "Rock";
        const string Paper = "Paper";
        const string Scissors = "Scissors";

        // Creates the score of the player and the computer
        uint playerScore = 0;
        uint computerScore = 0;
        
        while (true)
        {
            PlayGame(ref playerScore, ref computerScore, Rock, Paper, Scissors);
            
            // Restart the game
            Console.Write("Type [yes] to Play Again or [no] to quit: ");
            
            string answer = string.Empty; 
            while ((answer = Console.ReadLine()) != "yes" && answer != "no") 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.Write($"Incorrect answer! Type [yes] to Play Again or [no] to quit: "); 
                Console.ResetColor(); 
            }

            // Quit the game
            if (answer == "no")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
        }
    }

    private static void PlayGame(ref uint playerScore, ref uint computerScore, string Rock, string Paper, string Scissors)
    {
        while (true)
        {
            // The program first checks for correct input (move)
            try
            {
                string playerMove = GetPlayerMove();    // Get player's move (input)
                
                ValidMove(playerMove);  // Validate the move (input)

                playerMove = PlayerMove(playerMove, Rock, Paper, Scissors); // Assign correct string value
                
                string computerMove = ComputerMove(Rock, Paper, Scissors);  // Get computer's move
                
                GameAction(playerMove, computerMove, Rock, Paper, Scissors, ref playerScore, ref computerScore);    // Evaluate result
                
                break;  // exit the while-loop after one game
            }
            catch (ArgumentException exceptionMove)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"{exceptionMove.Message} Try again...");
                Console.ResetColor();
            }
        }
    }

    private static string GetPlayerMove()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Choose [r]ock, [p]aper, [s]cissors: ");
        Console.ResetColor();
        
        string playerMove = Console.ReadLine();
        
        return playerMove;
    }

    private static void ValidMove(string playerMove)
    {
        if (playerMove != "r" && playerMove != "rock" 
                              && playerMove != "p" && playerMove != "paper"
                              && playerMove != "s" && playerMove != "scissors")
        {
            throw new ArgumentException("Invalid input.");
        }
    }

    private static string PlayerMove(string playerMove, string Rock, string Paper, string Scissors)
    {
        // Defining player's move
        if (playerMove is "r" or "rock")
        {
            playerMove = Rock;
        }
        else if (playerMove is "p" or "paper")
        {
            playerMove = Paper;
        }
        else if (playerMove is "s" or "scissors")
        {
            playerMove = Scissors;
        }

        return playerMove;
    }
    
    private static string ComputerMove(string Rock, string Paper, string Scissors)
    {
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

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"The computer chose {computerMove}.");
        Console.ResetColor();
        
        return computerMove;
    }
    
    private static void GameAction(string playerMove, string computerMove, string Rock, string Paper, string Scissors, ref uint playerScore, ref uint computerScore)
    {
        if ((playerMove == Rock && computerMove == Scissors)
            || (playerMove == Paper && computerMove == Rock)
            || (playerMove == Scissors && computerMove == Paper))
        {
            playerScore++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You win.");
        }
        else if ((playerMove == Rock && computerMove == Paper)
                 || (playerMove == Paper && computerMove == Scissors)
                 || (playerMove == Scissors && computerMove == Rock))
        {
            computerScore++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You lose.");
        }
        else // Both the player and the computer used the same object (e.g. playerMove == Paper && computerMove == Paper) etc
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("This game was a draw.");
        }

        Console.ResetColor();
        Console.WriteLine($"Score so far - Player: {playerScore}, Computer: {computerScore}");
    }
}
