using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Random_Walk
{
    struct Position
    {
        public int row;
        public int col;
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int right = 0;
            int left = 1;
            int down = 2;
            int up = 3;
            int right_down = 4;
            int left_down = 5;
            int right_up = 6;
            int left_up = 7;

            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;

            Random random_number = new Random();

            Queue<Position> random_walk_elements = new Queue<Position>();
            random_walk_elements.Enqueue(new Position(10, 30));
            foreach (Position position in random_walk_elements)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.Write("*");
            }
            Position[] directions = new Position[]
                {
                    new Position(0, 1), //Right moving
                    new Position(0, -1), // Left moving
                    new Position(1, 0), // Down moving
                    new Position(-1, 0), // Up moving 
                    new Position(1, 1), // Right, down diagonal move
                    new Position(1, -1), // Left, down diagonal move 
                    new Position(-1, 1), // Right, up diagonal
                    new Position(-1, -1), // Left, up diagonal 
                };
            int direction = up; // Starting direction
            int random_choose_position;

           

            while (true)
            {
                random_choose_position = (random_number.Next(0, 7));
                if (random_choose_position == 0)
                {
                    direction = right;
                }
                if (random_choose_position == 1)
                {
                    direction = left;
                }
                if (random_choose_position == 2)
                {
                    direction = down;
                }
                if (random_choose_position == 3)
                {
                    direction = up;
               }
                if (random_choose_position == 4)
                {
                    direction = right_down;
                }
                if (random_choose_position == 5)
                {
                    direction = left_down;
                }
                if (random_choose_position == 6)
                {
                    direction = right_up;
                }
                if (random_choose_position == 7)
                {
                    direction = left_up;
                }
               Position walk_head = random_walk_elements.Last(); // Choose the last element of the Queue
               Position next_direction = directions[direction];  // Set the next direction
               Position walk_new_head = new Position(walk_head.row + next_direction.row, // define the position of the new snake head
                    walk_head.col + next_direction.col);

                random_walk_elements.Enqueue(walk_new_head);

                if (walk_new_head.row < 0 ||
                   walk_new_head.col < 0 ||
                   walk_new_head.row >= Console.WindowHeight ||
                   walk_new_head.col >= Console.WindowWidth)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("End of the random walker");
                    return;
                }
                    Console.SetCursorPosition(walk_new_head.col, walk_new_head.row);
                    Console.Write("*");
                

                Thread.Sleep(200);
            }
        }
    }
}
