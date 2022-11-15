using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Programs");
            Console.WriteLine("Harmonic Number");
            Console.WriteLine("Enter the Nth number:");
            double n = Convert.ToInt32(Console.ReadLine());
            double result = 1;
            for(int i=1; i< n;i++)
            {
                result += (float)1 / i;
            }
            Console.WriteLine($"The harmonic value obtained is: {result}");
            Console.ReadLine();
        }
    }
}
