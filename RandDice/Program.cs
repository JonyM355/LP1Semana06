using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random seed = new Random(int.Parse(args[1]));

            int sum = 0;

            if (args.Length > 2)
            {
                Console.WriteLine("Demasiados valores!");
                return;
            }
            else if (args.Length <= 1)
            {
                Console.WriteLine("Precisas no mínimo 2 valores!");
                return;
            }
            else
            {
                for (int i = 0; i < int.Parse(args[0]); i++)
                {
                    int rslt = seed.Next(1, 7);
                    
                    sum += rslt;
                }

                Console.WriteLine(sum);
            }
            
        }
    }
}