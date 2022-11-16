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
            Console.WriteLine("Vowel or Consonant Program");
            Console.WriteLine("Enter an alphabet :");
            char  alphabet = Convert.ToChar(Console.ReadLine().ToLower()); 
            switch(alphabet)
            {
                case 'a':
                    Console.WriteLine("{0} is an Vowel", alphabet);
                    break;
                case 'e':
                    Console.WriteLine("{0} is an Vowel", alphabet);
                    break;
                case 'i':
                    Console.WriteLine("{0} is an Vowel", alphabet);
                    break;
                case 'o':
                    Console.WriteLine("{0} is an Vowel", alphabet);
                    break;
                case 'u':
                    Console.WriteLine("{0} is an Vowel", alphabet);
                    break;
                default:
                    Console.WriteLine("{0} is an Consonant", alphabet);
                    break;

            }
            
            Console.ReadLine();
        }
    }
}
