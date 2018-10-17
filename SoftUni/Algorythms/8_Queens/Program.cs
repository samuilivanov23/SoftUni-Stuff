using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Queens
{
    class Program
    {
        const int SIZE = 8;
        static bool[,] chessboard = new bool[SIZE, SIZE];
        static int solutionsFound = 1;
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColumns = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();

        static void Main(string[] args)
        {
            PutQueens(0);
        }

        static void PutQueens(int row)
        {
            if(row == SIZE)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < SIZE; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col);
                        PutQueens(row + 1);
                        UnmarkedAllAtackedPositions(row, col);
                    }
                }
            }
        }

        private static void UnmarkedAllAtackedPositions(int row, int col)
        {
            attackedRows.Remove(row);
            attackedColumns.Remove(col);
            attackedLeftDiagonals.Remove(row - col);
            attackedRightDiagonals.Remove(row + col);
            chessboard[row, col] = false;
        }

        private static void MarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Add(row);
            attackedColumns.Add(col);
            attackedLeftDiagonals.Add(row - col);
            attackedRightDiagonals.Add(row + col);
            chessboard[row, col] = true;
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            var positionOcupied =
                        attackedRows.Contains(row) ||
                        attackedColumns.Contains(col) ||
                        attackedLeftDiagonals.Contains(row - col) ||
                        attackedRightDiagonals.Contains(row + col);
            return !positionOcupied;
        }

        private static void PrintSolution()
        {
            Console.WriteLine(solutionsFound);
            for (int row = 0; row < SIZE; row++)
            {
                for (int col = 0; col < SIZE; col++)
                {
                    if(chessboard[row, col])
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            solutionsFound++;
        }
    }
}
