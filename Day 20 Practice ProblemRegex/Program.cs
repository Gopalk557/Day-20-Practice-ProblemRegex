﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_20_Practice_ProblemRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegularExp patterns = new RegularExp();
            if (patterns.MobileNumber("+91 9507394794"))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}
