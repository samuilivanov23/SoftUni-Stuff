using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Program
    {
        static char[,] maze;

        static List<char> path = new List<char>();

        static void Main(string[] args)
        {
            ReadMaze();
            FindPaths(0, 0, 'S');
        }

        private static void FindPaths(int row, int col, char dir)
        {
            if (!IsInBounds(row, col))
            {
                return;
            }
            path.Add(dir);

            if(IfExit(row, col))
            {
                PrintPath();
            }
            else if(IsFree(row, col))
            {
                Mark(row, col);
                FindPaths(row, col + 1, 'R');
                FindPaths(row + 1, col, 'D');
                FindPaths(row, col - 1, 'L');
                FindPaths(row, col, 'U');
                UnMark(row, col);
            }

            path.RemoveAt(path.Count - 1);
        }

        private static void UnMark(int row, int col)
        {
            maze[row, col] = '*';
        }

        private static void Mark(int row, int col)
        {
            maze[row, col] = '-';
        }

        private static bool IsFree(int row, int col)
        {
            return maze[row, col] == '-';
        }

        private static void PrintPath()
        {
            Console.WriteLine(String.Join(String.Empty, path.Skip(1)));
        }

        private static bool IfExit(int row, int col)
        {
            return maze[row, col] == 'e';
        }

        private static bool IsInBounds(int row, int col)
        {
            return (row >= 0 && row < maze.GetLength(0)) && (col >= 0 && col < maze.GetLength(1));
        }

        private static void ReadMaze()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            maze = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                string str = Console.ReadLine();
                for (int j = 0; j < col; j++)
                {
                    maze[i, j] = str[j];
                }
            }
            path = new List<char>();
        }
    }
}
