using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake_Game
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
            double sleep_time = 100; // how fast is the snake

            int points = 0; // the points you earn by eating food
            Position[] directions = new Position[]
            {
                new Position(0, 1), // right
                new Position(0, -1), // left
                new Position(1, 0), // down
                new Position(-1, 0), // up

            };

            int direction = right; // starting direction(right)
            Random random_food_position = new Random();
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Position food = new Position(random_food_position.Next(0, Console.WindowHeight), // set a random position to the food
                random_food_position.Next(0,Console.WindowWidth));

            Console.SetCursorPosition(food.col, food.row); // draw the food
            Console.Write("%");

            Queue<Position> snake_elements = new Queue<Position>();

            for (int i =0; i<5; i++)//Choose how elements your snake will contain at the start
            {
                snake_elements.Enqueue(new Position(0,i));
            }

            foreach (Position position in snake_elements)
            {
                Console.SetCursorPosition(position.col, position.row);
                Console.Write("*");
            }

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userinput = Console.ReadKey();
                    if (userinput.Key == ConsoleKey.RightArrow && direction != left)
                    {
                        direction = right;
                    }
                    if (userinput.Key == ConsoleKey.LeftArrow && direction != right)
                    {
                        direction = left;
                    }
                    if (userinput.Key == ConsoleKey.DownArrow && direction != up)
                    {
                        direction = down;
                    }
                    if (userinput.Key == ConsoleKey.UpArrow && direction != down)
                    {
                        direction = up;
                    }
                }

                Position snake_head = snake_elements.Last(); // Choose the last element of the Queue
                Position next_direction = directions[direction];  // Set the next direction
                Position snake_new_head = new Position(snake_head.row + next_direction.row, // define the position of the new snake head
                   snake_head.col + next_direction.col);

                if(snake_new_head.row < 0 ||
                    snake_new_head.col < 0 ||
                    snake_new_head.row >= Console.WindowHeight ||
                    snake_new_head.col >= Console.WindowWidth ||
                    snake_elements.Contains(snake_new_head))
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Game over");
                    Console.WriteLine("You score {0} points", points);
                    if(points<100)
                    {
                        Console.WriteLine("LOOSER");
                    }
                    else if(points>100 && points<250)
                    {
                        Console.WriteLine("Well played");
                    }
                    else
                    {
                        Console.WriteLine("EXCELENT!!");
                    }
                    return;
                }

                snake_elements.Enqueue(snake_new_head);
                Console.SetCursorPosition(snake_new_head.col, snake_new_head.row);
                Console.Write("*");

                if (snake_new_head.col == food.col && snake_new_head.row == food.row)
                {
                    // feeding the snake
                    do
                    {
                        food = new Position(random_food_position.Next(0, Console.WindowHeight), // set a random position to the food again
                        random_food_position.Next(0, Console.WindowWidth));
                    }
                    while (snake_elements.Contains(food));

                    points += 10;
                    Console.SetCursorPosition(food.col, food.row); // draw the food again
                    Console.Write("@");
                }
                else
                {
                    // moving
    Position last = snake_elements.Dequeue();       // Delete the last element of the food
                    Console.SetCursorPosition(last.col, last.row);
                    Console.Write(" ");
                }

                sleep_time -= 0.1;
                Thread.Sleep((int)sleep_time);

            }
        }
    }
}
