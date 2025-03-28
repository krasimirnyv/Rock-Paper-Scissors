# ✊🖐✌️ Rock-Paper-Scissors – Console Game

## 💡 Project Title

A C# console-based implementation of the classic Rock-Paper-Scissors game, featuring input validation, colorful feedback, score tracking, and replay functionality.  
This project is designed for beginners who want to practice core programming concepts such as conditional logic, loops, methods, and user interaction in the console.

<p align="center">
  <img src="https://upload.wikimedia.org/wikipedia/commons/6/67/Rock-paper-scissors.svg" width="300px" alt="Rock Paper Scissors Illustration">
</p>

---

## 🧩 Project Summary

A classic C# console game where the player competes against the computer by choosing rock, paper, or scissors.  
The computer randomly selects its move, and the game determines the winner based on standard rules.  
It includes input validation, colorful feedback, score tracking, and replay functionality for an interactive experience.

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

## 📊 Game Flow Table

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

---

<h2>📸 Screenshots</h2>
<p>Below are some gameplay examples from the Rock-Paper-Scissors console game:</p>

<p align="center">
  <img src="images/Player wins.jpg" width="500" alt="Player wins">
  <br><em>Example 1: Player wins against the computer</em>
  <br>
</p>

<p align="center">
  <img src="images/Draw and win.jpg" width="500" alt="Draw and win">
  <br><em>Example 2: Game ends in a draw, followed by a win</em>
  <br>
</p>

<p align="center">
  <img src="images/Multiple losses and draws.jpg" width="500" alt="Multiple losses and draws">
  <br><em>Example 3: Multiple losses and draw outcomes</em>
  <br>
</p>

---

## 💻 **Link to the Source Code**
You can view the source code for this project here:

[Source Code](RockPaperScissors/RockPaperScissors/RockPaperScissors.cs)

---

## 🚀 Try the Demo

You can play the game directly in your web browser here:

<a href="https://replit.com/@krasimirnyv/Rock-Paper-Scissors-Game-by-Krasmir-Naydenov?v=1" target="_blank">
  <img alt="Play Button" src="images/Play.png" width="100">
</a>

---

## 🧠 Technologies Used
- C#
- .NET Console
- JetBrains Rider / Replit
- Git & GitHub for version control

---

## ✍ Author
Created by **Krasmir Naydenov** as part of a personal console projects series for beginners.

---

## 📄 License
Licensed under the [MIT License](LICENSE)
