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
}