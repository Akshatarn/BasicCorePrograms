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
            Console.WriteLine("Factors Program");
            Console.WriteLine("Enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=2; i*i<= n;i++)
            {
                while(n%i == 0)
                {
                    n = n / i;
                    Console.WriteLine(i + "");
                    Console.WriteLine();
                }
               
            }
            if(n!=1)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
