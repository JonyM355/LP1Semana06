using System;
using System.Data;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int numEnemies = int.Parse(args[0]);

            Enemy[] enmList = new Enemy[numEnemies];

            for (int i = 0; i < numEnemies; i++)
            {
                Console.Write($"Nome do inimigo {i}: ");
                string nome = Console.ReadLine();

                enmList[i - 1] = new Enemy(nome);
            }
            

            Console.WriteLine("Informações dos inimigos:");
            foreach (Enemy enemy in enmList)
            {
                Console.WriteLine("Nome: " + enemy.GetName() + 
                                ", Health: " + enemy.GetHealth() +
                                ", Shield " + enemy.GetShield());
            }

            enmList[0].TakeDamage(15);
            Console.WriteLine($"Health after damage: {enmList[0].GetHealth()}");

            enmList[0].PickupPowerUp(PowerUp.Health, 30);
            Console.WriteLine($"Health after pickup: {enmList[0].GetHealth()}");

            enmList[0].PickupPowerUp(PowerUp.Shield, 10);
            Console.WriteLine($"Shield after pickup: {enmList[0].GetShield()}");     
        
            Console.WriteLine(Enemy.GetPowerUp());
        }
    }
}