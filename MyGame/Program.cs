using System;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Insert 1 number!");
                return;
            }

           
            string argumento = args[0];


            bool isNumber = true;
            foreach (char c in argumento)
            {
                if (!char.IsDigit(c))
                {
                    isNumber = false;
                    break;
                }
            }


            if (!isNumber)
            {
                Console.WriteLine("Insert a number");
                return;
            }


            int numEnemies = int.Parse(argumento);

            if (numEnemies <= 0)
            {
                Console.WriteLine("Number of enemies should be higher than 0");
                return;
            }

            if (args.Length != numEnemies +1)
            {
                Console.WriteLine("Error!");
                return;
            }


            Enemy[] enmList = new Enemy[numEnemies];

            for (int i = 0; i < numEnemies; i++)
            {
                string nome = args[i + 1];
                enmList[i] = new Enemy(nome);
            }
            

            Console.WriteLine("Informações dos inimigos:");
            for (int i = 0; i < enmList.Length; i++)
            {
                Console.WriteLine("Nome: " + enmList[i].GetName() + 
                                ", Health: " + enmList[i].GetHealth() +
                                ", Shield " + enmList[i].GetShield());
            }
        }
    }

    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
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

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string playerName)
        {
            if (playerName.Length > 8)
            {
                name = playerName.Substring(0, 8);
            }

            else
            {
                name = playerName;
            }
        }

        public string GetName()
        {
            return name;
        }
    }
}