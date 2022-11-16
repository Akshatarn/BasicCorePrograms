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
            Console.WriteLine("Swap Two Numbers Program");
            Console.WriteLine("Enter the first number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number :");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.ReadLine();
        }
    }
}
