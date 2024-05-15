using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class Map
    {
        public int width {  get; set; }
        public int height { get; set; }

        public Map()
        {
            width = 100;
            height = 100;
        }

        public void drawMap()
        {
            Console.Clear();
            for(int  i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("-");
            }
            for(int i = 0;i < width; i++)
            {
                Console.SetCursorPosition(i, height);
                Console.Write("-");
            }

            for(int i = 0;i < height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("-");
            }

            for(int i = 0; i < height; i++)
            {
                Console.SetCursorPosition(width, i);
                Console.Write("-");
            }
        }
    }
}
