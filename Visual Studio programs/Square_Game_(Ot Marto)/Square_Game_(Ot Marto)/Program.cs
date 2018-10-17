using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Game__Ot_Marto_
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

           Position[] directions = new Position[]
            {
                new Position(0, 1), // right moving
                new Position(0, -1), // left moving
                new Position(1, 0), // down moving
                new Position(-1, 0), // up moving
            };
            
            int direction = right;


            int playground_rows=5;                              // this variable marks the change of the row the playgroung will be drawed.
            string[] Playground = {"oooooooooo"};
            for(int i = 0; i<=4; i++)
            {
                Console.SetCursorPosition(10, playground_rows);
                Console.WriteLine(Playground[0]);
                playground_rows++;
            }

            int x = 5 ;
            int y = 10;

            Position current_position = new Position(x, y);                              // set the starting position of the player's char
            Console.SetCursorPosition(current_position.col, current_position.row);       // set the Cursor at this position
            Console.Write("@");                                                       // draw the player's char at this position
           

            while (true)
            {
                
                    ConsoleKeyInfo user_input = Console.ReadKey();
                    if (user_input.Key == ConsoleKey.RightArrow)
                    {
                        direction = right;
                    }
                    if (user_input.Key == ConsoleKey.LeftArrow)
                    {
                        direction = left;
                    }
                    if (user_input.Key == ConsoleKey.DownArrow)
                    {
                        direction = down;
                    }
                    if (user_input.Key == ConsoleKey.UpArrow)
                    {
                        direction = up;
                    }

                    Position next_direction = directions[direction]; // define the direction that the player has chosen 

                    Position next_position = new Position(current_position.row + next_direction.row,  // define the next position of the player char
                        current_position.col + next_direction.col);
                    
                    Console.SetCursorPosition(next_position.col, next_position.row); // draw the player char at the next position
                    Console.Write("@");

                    Console.SetCursorPosition(current_position.col, current_position.row);
                    Console.Write("o");

                    current_position = next_position; 

                
            }
            Console.SetCursorPosition(0, 0);
        }
    }
}
