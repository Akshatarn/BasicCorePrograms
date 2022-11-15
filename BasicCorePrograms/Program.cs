using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");
            Console.WriteLine("Flip Coin ");
            Random random = new Random();
            Console.WriteLine("Enter the number of times you want to flip coin");
            int n = Convert.ToInt32(Console.ReadLine());
            int head = 0, tail = 0;
            for (int i = 0; i < n; i++)
            {
                double coinFlipped = random.NextDouble();
                if (coinFlipped < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
            double headPercentage = head * 100 / n;
            Console.WriteLine($"Head won {head} times, Head Score: {headPercentage}%");
            double tailPercentage = tail * 100 / n;
            Console.WriteLine($"Tail won {tail} times, Tail Score: {tailPercentage}%");
            Console.ReadLine();
        }
    }
}
