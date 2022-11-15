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
            Console.WriteLine("Power Of 2 Program");
            int baseNumber = 2;
            Console.WriteLine("Enter the power value:");
            int power = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i< power;i++)
            {
                baseNumber = baseNumber * 2;
            }
            Console.WriteLine(baseNumber);
            Console.ReadLine();
        }
    }
}
