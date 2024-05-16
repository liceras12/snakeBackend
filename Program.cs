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
            Food food = new Food();

            Console.WriteLine("Press Enter");
            Console.Read();
            while (!finished)
            {
                try
                {
                    map.drawMap();
                    Console.SetCursorPosition(90, 5);
                    Console.WriteLine("Score: " + snake.score);
                    snake.input();
                    food.drawFood();
                    snake.drawSnake();
                    snake.moveSnake();
                    snake.eat(food.foodLocation(), food);
                    snake.collision();
                    snake.hitWall(map);
                }
                catch (SnakeException e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    
                    Console.WriteLine("Do you want to play again? (y/n)");
                    char c = Console.ReadKey().KeyChar;

                    switch (c)
                    {
                        case 'y':
                            
                            snake.x = 10;
                            snake.y = 10;
                            snake.score = 0;
                            snake.snakeBody.RemoveRange(0, snake.snakeBody.Count-1);
                            break;
                        case 'n':
                            finished = true;
                            break;
                    }
                }
            }
        }
    }
}