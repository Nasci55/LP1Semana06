using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enemy[] enemies = new Enemy[int.Parse(args[0])];

            for (int numOfEnemies = 0; numOfEnemies < int.Parse(args[0]); numOfEnemies++)
            {
                Console.WriteLine($"Nome do inimigo {numOfEnemies + 1}");
                enemies[numOfEnemies] = new Enemy(Console.ReadLine());
                System.Console.WriteLine(enemies[numOfEnemies]);
            }


        }
    }
}
