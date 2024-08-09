using System;

class Program
{
    static char[,] board = {
        {'_', '_', '_'},
        {'_', '_', '_'},
        {'_', '_', '_'}
    };

    static char currentPlayer = 'X';
    static bool isAIEnabled = false; // Player vs AI mode

    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");
        Console.WriteLine("Select mode: ");
        Console.WriteLine("1. Player vs Player");
        Console.WriteLine("2. Player vs AI");
        Console.Write("Enter choice (1 or 2): ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 2)
        {
            isAIEnabled = true;
        }

        do
        {
            Console.Clear();
            DisplayBoard();
            if (currentPlayer == 'X' || !isAIEnabled)
            {
                GetPlayerMove();
            }
            else
            {
                GetAIMove();
            }
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
        int move;

        while (!int.TryParse(Console.ReadLine(), out move) || !IsValidMove(move))
        {
            Console.WriteLine("Invalid move. Try again (1-9):");
        }

        UpdateBoard(move);
        SwitchPlayer();
    }

    static void GetAIMove()
    {
        Random random = new Random();
        int move;
        do
        {
            move = random.Next(1, 10); // Random move between 1 and 9
        } while (!IsValidMove(move));

        Console.WriteLine($"\nAI selects move {move}");
        UpdateBoard(move);
        SwitchPlayer();
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

        board[row, col] = currentPlayer;
    }

    static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    static bool CheckForWin()
    {
        // Check rows and columns
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                return true;
            if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                return true;
        }

        // Check diagonals
        if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
            return true;
        if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
            return true;

        return false;
    }

    static bool CheckForTie()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == '_')
                    return false;
            }
        }
        return true;
    }
}
