using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace snake
{
    public class Snake
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key, dir;
        //char key = 'w';
        //char dir = 'u';

        public List<Position> snakeBody { get; set; }

        public int x { get; set; }
        public int y { get; set; }
        public int score { get; set; }

        public Snake()
        {
            x = 10;
            y = 10;
            score = 0;

            snakeBody = new List<Position>();
            snakeBody.Add(new Position(x, y));
        }

        public void drawSnake()
        {
            foreach (Position position in snakeBody)
            {
                Console.SetCursorPosition(position.x, position.y);
                Console.Write("O");
            }
        }

        public void input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.KeyChar;
            }
        }

        private void direction()
        {
            if (key == 'w' && dir != 'd')
            {
                dir = 'u';
            }
            else if (key == 's' && dir != 'u')
            {
                dir = 'd';
            }
            else if (key == 'd' && dir != 'l')
            {
                dir = 'r';
            }
            else if (key == 'a' && dir != 'r')
            {
                dir = 'l';
            }
        }

        public void moveSnake ()
        {
            direction();

            if (dir == 'u')
            {
                y--;
            }
            else if (dir == 'd')
            {
                y++;
            }
            else if (dir == 'r')
            {
                x++;
            }
            else if (dir == 'l')
            {
                x--;
            }
            snakeBody.Add(new Position(x, y));
            snakeBody.RemoveAt(0);
            Thread.Sleep(10);
        }

        public void eat(Position food, Food f)
        {
            Position head = snakeBody[snakeBody.Count - 1];

            if (head.x == food.x && head.y == food.y)
            {
                snakeBody.Add(new Position(head.x, head.y));
                f.foodNewLocation();
                score++;
            }
        }

        public void collision()
        {
            Position head = snakeBody[snakeBody.Count - 1];

            for (int i=0; i<snakeBody.Count - 2; i++)
            {
                Position snakeB = snakeBody[i];
                if (head.x == snakeB.x && head.y == snakeB.y)
                {
                    throw new SnakeException("Game Over");
                }
            }
        }

        public void hitWall(Map map)
        {
            Position head = snakeBody[snakeBody.Count - 1];
            if(head.x >= map.width || head.x <= 0 || head.y >= map.height || head.y <= 0)
            {
                throw new SnakeException("Game Over");
            }
        }

    }
}
