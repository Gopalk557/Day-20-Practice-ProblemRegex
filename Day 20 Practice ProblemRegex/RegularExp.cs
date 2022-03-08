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
        public static string regex = "^[a-zA-Z0-9]{3,10}[.]?[a-zA-Z0-9]{3,10}[@][a-z]{3,10}[.][a-z]{2,3}[.]?([a-z]{2,2})?$";
        public bool Email(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
}
