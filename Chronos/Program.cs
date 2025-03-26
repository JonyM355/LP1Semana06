using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500);
            crono1.Stop();

            crono2.Start();
            Thread.Sleep(750);
            crono2.Stop();

            Console.WriteLine($"Crono1: {crono1.Elapsed.TotalSeconds:f4}s");
            Console.WriteLine($"Crono2: {crono2.Elapsed.TotalSeconds:f4}s");
        }
    }
}