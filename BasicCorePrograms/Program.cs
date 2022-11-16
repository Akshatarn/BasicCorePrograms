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
            Console.WriteLine("Quotient And Remainder Program");
            Console.WriteLine("Enter the number to be divided(divident):");
            int divident = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number should be divided from(Divisor):");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int remainder = divident / divisor;
            int quotient = divident % divisor;
            Console.WriteLine("Remainder:" + remainder);
            Console.WriteLine("Quotient:" + quotient);
        }
    }
}
