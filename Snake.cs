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

        public int x { get; set; }
        public int y { get; set; }

        public Snake()
        {
            x = 20;
            y = 20;
        }

        public void drawSnake()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }

        public void input()
        {
            if (Console.KeyAvailable)
            {
                key = keyInfo.KeyChar;
            }
        }


    }
}
