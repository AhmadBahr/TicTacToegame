using System;

class Program
{
    static char[,] board = {
        {'_', '_', '_'},
        {'_', '_', '_'},
        {'_', '_', '_'}
    };

    static char currentPlayer = 'X';

    static void Main()
    {
        do
        {
            Console.Clear();
            DisplayBoard();
            GetPlayerMove();
        } while (!CheckForWin() && !CheckForTie());

        Console.Clear();
        DisplayBoard();

        if (CheckForWin())
        {
            Console.WriteLine($"Player {currentPlayer} wins!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }

        Console.ReadLine();
    }

    static void DisplayBoard()
    {
        Console.WriteLine("Tic-Tac-Toe Board:");
        Console.WriteLine("-----");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"|{board[i, j]}|");
            }
            Console.WriteLine("\n-----");
        }
    }

    static void GetPlayerMove()
    {
        Console.WriteLine($"\nPlayer {currentPlayer}, enter your move (1-9):");
        int move = int.Parse(Console.ReadLine());

        if (IsValidMove(move))
        {
            UpdateBoard(move);
            SwitchPlayer();
        }
        else
        {
            Console.WriteLine("Invalid move.Try again");
            Console.ReadLine();
        }
    }
    static bool IsValidMove(int move)
    {
        if (move < 1 || move > 9)
            return false;

         int row = (move - 1) / 3;
         int col = (move - 1) % 3;

        return board[row, col] == '_';
    }

    static void UpdateBoard(int move)
    {
        int row = (move - 1) / 3;
        int col = (move - 1) % 3;

        Console.WriteLine($"\nEnter your symbol ('X' or 'O'): ");
        char symbol = char.Parse(Console.ReadLine());

        board[row, col] = symbol;
    }

}