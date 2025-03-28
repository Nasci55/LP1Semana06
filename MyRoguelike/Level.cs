using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MyRoguelike
{
    public class Level
    {

        public Enemy[] numOfRooms;
        public string difficulty;
        private int totalRooms;
        private int totalEnemies;

        public Level(int howManyRooms, Toughness diff)
        {
            numOfRooms = new Enemy[howManyRooms];
            Toughness difficulty = diff;

            totalRooms = howManyRooms;
        }

        public Enemy[] SetEnemyInRoom(int room, Enemy enemy)
        {
            numOfRooms[room] = enemy;
            totalEnemies++;

            return numOfRooms;

        }

        public string GetToughness() => difficulty;

        public int GetNumRooms() => totalRooms;

        public int GetNumEnemies() => totalEnemies;

        public void PrintEnemies()
        {
            foreach (Enemy enemy in numOfRooms)
            {
                System.Console.WriteLine($"{numOfRooms}, {numOfRooms}");

            }


        }
    }
}