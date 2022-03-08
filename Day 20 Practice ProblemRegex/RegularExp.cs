using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day_20_Practice_ProblemRegex
{
     class RegularExp
    { 
        public static string regex = "^[A-Z][a-z0-9]{0,5}[.@#$_]";
        public bool MobileNumber(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
}
