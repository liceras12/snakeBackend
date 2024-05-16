using System;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            Map map = new Map();
            Snake snake = new Snake();

            while (!finished)
            {
                map.drawMap();
                snake.drawSnake();
                Console.Read();
            }
        }
    }
}