using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNIGHTS_TOUR_GUI_BASED
{
    internal class backtracking
    {
            public int boardSize = 8;
            public int[,] board = new int[8,8];
      
            public bool SolveTour(int startX,int startY)
            {
            try
            {
                int[] moveX = { 2, 1, -1, -2, -2, -1, 1, 2 };
                int[] moveY = { 1, 2, 2, 1, -1, -2, -2, -1 };

                InitializeBoard();

                board[startX, startY] = 1;

                if (!SolveRecursively(startX, startY, 2, board, moveX, moveY))
                {
                    Console.WriteLine("No solution found");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in SolveTour: " + ex.Message);
                return false;
            }
        }

            public bool SolveRecursively(int x, int y, int moveN, int[,] board, int[] MoveX, int[] MoveY)
            {
            try
            {
                int k, nextX, nextY;
                if (moveN == 65)
                {
                    Console.WriteLine("Traveled through all positions :)");
                    return true;
                }

                for (k = 0; k < 8; k++)
                {
                    nextX = x + MoveX[k];
                    nextY = y + MoveY[k];
                    if (SafeMove(nextX, nextY, board))
                    {
                        board[nextX, nextY] = moveN;
                        if (SolveRecursively(nextX, nextY, moveN + 1, board, MoveX, MoveY))
                        {
                            return true;
                        }
                        else
                        {
                            board[nextX, nextY] = -1;
                        }
                    }

                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in SolveRecursively: " + ex.Message);
                return false;
            }
        }

            public void InitializeBoard()
            {
                for (int i = 0; i < boardSize; i++)
                {
                    for (int j = 0; j < boardSize; j++)
                    {
                        board[i, j] = -1;
                    }
                }
            }
            public bool SafeMove(int x, int y, int[,] board)
            {
                return (x >= 0 && y >= 0 && x < boardSize && y < boardSize && board[x, y] == -1);
            }
           
            public void reset()
            {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = -1;
                }
            }
        }
    }
    }

