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
            Console.WriteLine("Even Or Odd Program");
            Console.WriteLine("Enter the  number :");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n%2 == 0)
            {
                Console.WriteLine("{0} is an even number",n);
            }
            else
            {
                Console.WriteLine("{0} is an odd number" , n);
            }
            
            Console.ReadLine();
        }
    }
}
