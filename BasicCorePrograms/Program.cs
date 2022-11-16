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
            Console.WriteLine("Largest Of Three Numbers Program");
            Console.WriteLine("Enter three numbers :");
            int a = Convert.ToInt32(Console.ReadLine()); 
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("{0} is largest", a);
            }
            else if (b > c && b > a)
            {
                Console.WriteLine("{0} is largets", b);
            }
            else
            {
                Console.WriteLine("{0} is largest", c)
            }
            
            Console.ReadLine();
        }
    }
}
