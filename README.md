# TicTacToe Game

## Table of Contents
1. [**General Info**](#general-info)
2. [**Technologies Used**](#technologies-used)
3. [**Setup**](#setup)
4. [**Code & Snippets**](#CodeSnippets)
   
## General Info
A Tic-Tac-Toe simulation game created using C# with a graphical user interface (GUI). The game supports two different modes:

. Player vs. Player: Two players take turns making moves on the same computer.
Player vs. AI: One player competes against an AI opponent, with the AI making random moves.
The goal of the game is to align three of your marks (either X or O) horizontally, vertically, or diagonally to win. If all squares are filled and no player has won, the game ends in a tie.

## Technologies Used
- Csharp
  
## Setup
Objective: The primary goal of Tic-Tac-Toe is to align three of your marks (either X or O) in a horizontal, vertical, or diagonal row on the 3x3 game board. The player who achieves this first wins the game.

Game Board: The game board consists of a 3x3 grid of cells. Each cell can be empty or occupied by a mark (X or O).

## Gameplay:
. Turn Order: Players take turns placing their mark in an empty cell. The first player is designated as "X," and the second player is designated as "O."

2. Mark Placement: A player must select an empty cell to place their mark. If a cell is already occupied, it cannot be overwritten.

3. Winning Condition: The game ends when one player aligns three of their marks in a row, column, or diagonal.

 4. Draw Condition: If all cells are filled and no player has aligned three marks, the game ends in a draw.

5. Invalid Moves: Moves made to occupied cells or outside the range of the board are considered invalid. Players must choose a valid, empty cell.

## Modes
1. Player vs. Player

2. Description: In this mode, two players take turns on the same computer. Player 1 uses "X" and Player 2 uses "O."

Gameplay:

Players alternate turns, making one move per turn.
Each player manually selects their move by choosing an empty cell.
The game continues until one player wins or the game ends in a draw.
Interaction: Both players must be present to play the game, as it requires turn-based input from each player.

Player vs. AI

Description: In this mode, one player (Player 1) competes against an AI opponent. Player 1 uses "X," and the AI uses "O."

Gameplay:

Player 1 takes their turn first by manually selecting an empty cell.
The AI then makes a move by selecting a random empty cell.
The game continues in this alternating fashion until either Player 1 or the AI wins, or the game ends in a draw.
AI Behavior: The AI uses a simple random move algorithm, meaning it selects an empty cell without employing advanced strategies.



## Code & Snippets

![Capture](https://github.com/AhmadBahr/TicTacToegame/assets/150359856/5dfcd9e0-53fc-43bb-8bbe-0471bfa24f37)
![Capture2](https://github.com/AhmadBahr/TicTacToegame/assets/150359856/9de86919-ef14-4b5a-ab90-7519d669f3ae)

![1](https://github.com/AhmadBahr/TicTacToegame/assets/150359856/1b905a46-7575-45f5-aaa8-c783de588ee4)
![2](https://github.com/AhmadBahr/TicTacToegame/assets/150359856/84b01175-3bd3-4b77-a325-9310597b0c83)
![4](https://github.com/AhmadBahr/TicTacToegame/assets/150359856/ac0acb1d-18d4-4ba2-9eed-40c6695010d4)
![4 (1)](https://github.com/AhmadBahr/TicTacToegame/assets/150359856/161cd501-3af6-44f0-960e-2520d6055b97)
![5](https://github.com/AhmadBahr/TicTacToegame/assets/150359856/e00ea68e-c256-4879-ab5a-83cd5a2e4051)
