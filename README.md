# Rock-Paper-Scissors Game
Rock - Paper - Scissors is a simple console game for beginners.

Link for the project's source code:
https://github.com/krasimirnyv/Rock-Paper-Scissors/blob/main/RockPaperScissors/RockPaperScissors/RockPaperScissors.cs

Project Goals:
The goal of this project is to implement a simple console-based version of the classic Rock-Paper-Scissors game, where a human player competes against the computer. The purpose is to apply fundamental programming skills in C#, such as using variables, conditional logic, loops, input/output operations and methods. The project encourages learning through practical coding while also building a foundation for version control, documentation, and publishing projects on GitHub.

The game allows the player to choose one of three options: rock, paper, or scissors. The computer randomly selects one as well, and the game determines the winner based on standard rules:
	•	Rock beats scissors
	•	Scissors beats paper
	•	Paper beats rock

This game can be played repeatedly and keeps track of the total scores of both the player and the computer.

My Solution:
The program of the game is implemented using C# as a console application built with .NET. The solution is modular and consists of several methods that separate the core functionalities of the game:
	•	Input handling: User input is validated and transformed into game logic using string matching and conditionals.
	•	Randomization: The System.Random class is used to simulate the computer’s move.
	•	Game rules: A set of if/else statements define the outcome of the game by comparing the user and computer choices.
	•	Scoring system: Two uint counters track the scores of the player and computer throughout the session. These are passed using the ref keyword to allow state persistence across game rounds.
	•	Console styling: Console.ForegroundColor and Console.ResetColor() are used to highlight different types of messages (e.g. prompts in blue, wins in green, losses in red).
	•	Loop control: The player is asked after each round whether they want to play again. This is handled using a while loop and conditional logic.
	•	Modularity: The code is structured with helper methods (GetPlayerMove, ValidMove, ComputerMove, GameAction) to improve readability and maintainability.

The project is built entirely with native .NET libraries, without external dependencies, and is designed to run smoothly in any C#-compatible terminal.
