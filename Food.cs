using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class Food
    {
        public Position foodPosition = new Position();

        Random random = new Random();
        Map map = new Map();
        public Food()
        {
            foodPosition.x = random.Next(5, map.width);
            foodPosition.y = random.Next(5, map.height);
        }

        public void drawFood()
        {
            Console.SetCursorPosition(foodPosition.x, foodPosition.y);
            Console.Write("F");
        }

        public Position foodLocation()
        {
            return foodPosition;
        }

        public void foodNewLocation()
        {
            foodPosition.x = random.Next(5, map.width);
            foodPosition.y = random.Next(5, map.height);
        }
    }
}
