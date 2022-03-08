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
            // !0
             //public static string regex = "^([A-Za-z0-9]+[.#+_])*[A-Za-z0-9]+[@][A-Za-z]+[.][A-Za-z]{2,3}([.][A-Za-z]{2})?$";
             //public static string RegexRulesFor3char = "^([0-9]*[a-zA-Z]{3,})[0-9a-zA-Z]*$";
             //public static string Regex_Pincode = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
           // public static string regex = "^[1-9][0-9]{2}[ ]?[0-9]{3}$";
        public static string regex = "^[A-Z][a-z]{4}$";
        public bool validateFirstName(string sample)
        {
            return Regex.IsMatch(sample, regex);
        }
    }
}
