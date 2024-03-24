using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MapGenerator MyMapGenerator = new MapGenerator();
            Player MyPlayer = new Player();
            
            MyMapGenerator.GenerateLabyrinth();
            MyPlayer.IniChar(100);
           // MyChar.Character(1,1);
            Console.ReadKey();
        }
    }
}
