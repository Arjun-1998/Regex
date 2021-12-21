using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexPattern
{
    public class Pattern
    {
         public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$"; //Arjun

             //Method for first name 
         public bool validateFirstName(string fname)
         {

             return Regex.IsMatch(fname, REGEX_FIRSTNAME);
         }
    }
}
