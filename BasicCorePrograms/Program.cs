﻿using System;
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
            Console.WriteLine("Leap Year Program");
            Console.WriteLine("Enter the year in YYYY format:");
            int year = Convert.ToInt32(Console.ReadLine());
            if((year % 4 == 0) &&(year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.", year);
            }
            Console.ReadLine();
        }
    }
}
