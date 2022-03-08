using System;
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
            Console.WriteLine("1st latter must be capital");
            Console.WriteLine("Minimum 8 char");
            Console.WriteLine("At least 1 numeric value is must");
            Console.WriteLine("At least 1 special char");
            RegularExp patterns = new RegularExp();
            if (patterns.MobileNumber("Gop1.122"))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}
