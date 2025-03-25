# Rock-Paper-Scissors Game
Project: Rock - Paper - Scissors is a simple console game for beginners.

<p align="center">
  <img src="https://upload.wikimedia.org/wikipedia/commons/6/67/Rock-paper-scissors.svg" width="300px" alt="Rock Paper Scissors Illustration">
</p>

## 💻 **Link to the Source Code**

You can view the source code for this project here:

[Source Code](RockPaperScissors.cs)

---

## 📌 Project Goals
The goal of this project is to implement a simple console-based version of the classic Rock-Paper-Scissors game, where a human player competes against the computer. The purpose is to apply fundamental programming skills in C#, such as using variables, conditional logic, loops, input/output operations and methods. The project encourages learning through practical coding while also building a foundation for version control, documentation, and publishing projects on GitHub.

The game allows the player to choose one of three options: rock, paper, or scissors. The computer randomly selects one as well, and the game determines the winner based on standard rules:

- Rock beats scissors
- Scissors beats paper
- Paper beats rock

This game can be played repeatedly and keeps track of the total scores of both the player and the computer.

---

## ✅ My Solution
The program of the game is implemented using C# as a console application built with .NET. The solution is modular and consists of several methods that separate the core functionalities of the game:

- Input handling: User input is validated and transformed into game logic using string matching and conditionals.
- Randomization: The System.Random class is used to simulate the computer’s move.
- Game rules: A set of if/else statements define the outcome of the game by comparing the user and computer choices.
- Scoring system: Two uint counters track the scores of the player and computer throughout the session. These are passed using the ref keyword to allow state persistence across game rounds.
- Console styling: Console.ForegroundColor and Console.ResetColor() are used to highlight different types of messages (e.g. prompts in blue, wins in green, losses in red).
- Loop control: The player is asked after each round whether they want to play again. This is handled using a while loop and conditional logic.
- Modularity: The code is structured with helper methods (GetPlayerMove, ValidMove, ComputerMove, GameAction) to improve readability and maintainability.

The project is built entirely with native .NET libraries, without external dependencies, and is designed to run smoothly in any C#-compatible terminal.

---

## 📋 Input and Output

The player enters one of the following options:

- `rock` or `r`
- `paper` or `p`
- `scissors` or `s`

The computer chooses a random option and then reveals the **winner**.

---

## 📊 Solution

The table below shows all possible outcomes of the game, based on both the player’s and the computer’s choices:

| You       | Computer  | Outcome     |
|-----------|-----------|-------------|
| rock      | rock      | Draw        |
| rock      | paper     | You lose    |
| rock      | scissors  | You win     |
| paper     | rock      | You win     |
| paper     | paper     | Draw        |
| paper     | scissors  | You lose    |
| scissors  | rock      | You lose    |
| scissors  | paper     | You win     |
| scissors  | scissors  | Draw        |

The program handles all these situations using a series of checks in the code.
