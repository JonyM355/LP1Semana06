using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        static int powerup;



        public Enemy(string name)
        {
            this.name = SetName(name);
            health = 100;
            shield = 0;
        }

        static Enemy()
        {
            powerup = 0;
        }

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

        public string SetName(string playerName)
        {
            if (playerName.Length > 8)
            {
                name = playerName.Substring(0, 8);
            }

            else
            {
                name = playerName;
            }

            return name;
        }

        public void PickupPowerUp(PowerUp pp, float f)
        {
            if (pp == PowerUp.Health)
            {
                this.health += f;
                if (this.health > 100)
                {
                    this.health = 100;
                }
            }

            if (pp == PowerUp.Shield)
            {
                this.shield += f;
                if (this.shield > 100)
                {
                    this.shield = 100;
                }
            }

            powerup += 1;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public static int GetPowerUp()
        {
            return powerup;
        }
    }
}