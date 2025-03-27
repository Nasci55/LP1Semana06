using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;


        public Enemy(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName() => name;

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public float GetHealth() => health;

        public float GetShield() => shield;

        public string SetName(string playerName)
        {
            string name = playerName;
            int stringLenght = name.Length;


            if (stringLenght > 8)
            {
                name = name.Substring(0, 8);
            }
            return name;
        }

        private void PickupPowerUp(PowerUp powerUp, float num)
        {
            if (powerUp == PowerUp.health)
            {
                health += num;
                if (health > 100)
                {
                    health = 100;
                }
            }




        }
    }
}