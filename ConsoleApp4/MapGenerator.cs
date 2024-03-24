using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class MapGenerator
    {
        public int width = 25;
        public int height = 100;
        

        public void GenerateLabyrinth()
        {
            // Генерация лабиринта
            int[,] labyrinth = new int[width, height];
            Random random = new Random();
            int value = random.Next(2);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    labyrinth[i, j] = random.Next(2); // 0 - стена, 1 - проход
                }
            }

            // Отображение лабиринта на экране
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (labyrinth[i, j] == 0)
                    {
                        Console.Write("█");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}