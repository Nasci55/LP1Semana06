using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;

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
            difficulty = Convert.ToString(diff);


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

            for (int i = 0; i < numOfRooms.Length; i++)
            {
                if (numOfRooms[i] != null)
                    System.Console.WriteLine($"{i.ToWords(new CultureInfo("us"))} room: {numOfRooms[i].GetName()}");
            }


        }
    }
}