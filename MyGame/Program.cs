using System;
using System.Data;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Enemy[] enemies = new Enemy[int.Parse(args[0])];

            for (int numOfEnemies = 0; numOfEnemies < int.Parse(args[0]); numOfEnemies++)
            {

                Console.Write($"Nome do inimigo {numOfEnemies + 1}: ");
                enemies[numOfEnemies] = new Enemy(Console.ReadLine());

            }

            foreach (Enemy newEnemy in enemies)
            {
                newEnemy.TakeDamage(15);
                newEnemy.PickupPowerUp(PowerUp.health, 5);
                newEnemy.PickupPowerUp(PowerUp.shield, 500);
                Console.WriteLine($"{newEnemy.GetName()} {newEnemy.GetHealth()} {newEnemy.GetShield()}");

            }
            System.Console.WriteLine($"The number of PowerUps picked up was {Enemy.GetPowerUpsGotten()}");
        }
    }
}
