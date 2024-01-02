using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNIGHTS_TOUR_GUI_BASED
{
    internal class Warnsdoff
    {
       public  int[,] chess_Board = {
        {0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0 },
        {0,0,0,0,0,0,0,0 },
        {0,0,0,0,0,0,0,0 },
        {0,0,0,0,0,0,0,0 },
        {0,0,0,0,0,0,0,0 },
        {0,0,0,0,0,0,0,0 },
        {0,0,0,0,0,0,0,0 }
        };


         int[] xMoves = { 2, 1, -1, -2, -2, -1, 1, 2 };
         int[] yMoves = { 1, 2, 2, 1, -1, -2, -2, -1 };

        public int[,] possibilities(int x, int y)
        {
            int[,] possible_moves = new int[8, 2];
            for (int i = 0; i < 8; i++)
            {
                if ((x + xMoves[i] >= 0) && (y + yMoves[i] >= 0) && (x + xMoves[i] < 8) && (y + yMoves[i] < 8) && (chess_Board[x + xMoves[i], y + yMoves[i]] == 0))
                {
                    possible_moves[i, 0] = x + xMoves[i];
                    possible_moves[i, 1] = y + yMoves[i];
                }
                else
                {
                    possible_moves[i, 0] = -1;
                    possible_moves[i, 1] = -1;
                }

            }
            return possible_moves;
        }
        public int count_possibilities(int x, int y)
        {

            int count = 0;
            int[,] possible = possibilities(x, y);
            for (int i = 0; i < possible.GetLength(0); i++)
            {
                if (possible[i, 0] != -1 && possible[i, 1] != -1)
                {
                    count++;
                }
            }
            return count;
        }

        public (int, int) solve(int[,] arr)
        {
            int min = int.MaxValue;
            int min_x = -1;
            int min_y = -1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i, 0] == -1 && arr[i, 1] == -1) { continue; }
                else
                {
                    int temp = count_possibilities(arr[i, 0], arr[i, 1]);
                    if (temp < min)
                    {
                        min = temp;
                        min_x = arr[i, 0];
                        min_y = arr[i, 1];
                    }
                }
            }
            return (min_x, min_y);
        }


        static int counter = 0;

        public void move(int a, int b)
        {
            while (counter < 64)
            {
                chess_Board[a, b] = ++counter;
                var (x, y) = solve(possibilities(a, b));
                a = x;
                b = y;
            }
        }

        public void print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t"); ;
                }
                Console.WriteLine();
            }
        }
    }
}
