using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];

            while (true)
            {
                Console.Clear();

                Render(board);

                if (Logic.CheckPlayerWin(board))
                {
                    Console.WriteLine("You won!");
                }

                int choiceY = Convert.ToInt32(Console.ReadLine());
                int choiceX = Convert.ToInt32(Console.ReadLine());
                Player.Move(board, choiceY, choiceX);
            }
        }

        static void Render(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != 'X')
                    {
                        board[i, j] = ' ';
                    }
                }
            }

            char aa = board[0,0];
            char ab = board[0,1];
            char ac = board[0,2];

            char ba = board[1,0];
            char bb = board[1,1];
            char bc = board[1,2];

            char ca = board[2,0];
            char cb = board[2,1];
            char cc = board[2,2];

            Console.WriteLine("  1|2|3");
            Console.WriteLine($"1:{aa}|{ab}|{ac}");
            Console.WriteLine("  -----");
            Console.WriteLine($"2:{ba}|{bb}|{bc}");
            Console.WriteLine("  -----");
            Console.WriteLine($"3:{ca}|{cb}|{cc}");
        }
    }

    static class Logic
    {
        public static bool CheckPlayerWin(char[,] board)
        {
            //first we will check each row
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == 'X' && board[row, 1] == 'X' && board[row, 2] == 'X')
                {
                    return true;
                }
            }

            //then each column
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == 'X' && board[1, col] == 'X' && board[2, col] == 'X')
                {
                    return true;
                }
            }

            //check each diagonal
            if (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X')
            {
                return true;
            }
            else if (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X')
            {
                return true;
            }

            return false;
        }

        public static bool CheckComputerWin(char[,] board)
        {
            //first we will check each row
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] == 'O' && board[row, 1] == 'O' && board[row, 2] == 'O')
                {
                    return true;
                }
            }

            //then each column
            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] == 'O' && board[1, col] == 'O' && board[2, col] == 'O')
                {
                    return true;
                }
            }

            //check each diagonal
            if (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O')
            {
                return true;
            }
            else if (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O')
            {
                return true;
            }

            return false;
        }

        public static char[,] BestMove(char[,] board)
        {
            return null;
        }
    }

    static class Player
    {
        public static char[,] Move(char[,] board, int y, int x)
        {
            if (x < 1)
            {
                x = 1;
            }
            else if (x > 3)
            {
                x = 3;
            }
            
            if (y < 1)
            {
                y = 1;
            }
            else if (y > 3)
            {
                y = 3;
            }

            if (board[y - 1, x - 1] == 'X')
            {
                return board;
            }
            else
            {
                board[y - 1, x - 1] = 'X';

                return board;
            }
        }
    }
}
