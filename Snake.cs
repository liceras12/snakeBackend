using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class Snake
    {
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
        char key = 'w';
        char dir = 'u';

        List<Position> snakeBody;

        public int x { get; set; }
        public int y { get; set; }

        public Snake()
        {
            x = 20;
            y = 20;

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
                key = keyInfo.KeyChar;
            }
        }

        private void direction()
        {
            if(key == 'w' && dir != 'd' )
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

        public void move()
        {
            direction();

            if (dir == 'u'   )
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
        }


    }
}
