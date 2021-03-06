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
        public static string REGEX_LASTNAME= "^[A-Z]{1}[A-Za-z]{2,}$"; //Jaiswal
        public bool validateLastName(string lname)
        {
            return Regex.IsMatch(lname, REGEX_LASTNAME);
        }
        public static string REGEX_EMAIL = "^[a-zA-Z0-9.]+@[A-Za-z0-9]+.[A-Za-z]{2,4}$";

        //Method for email address
        public bool valiadtaeEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }

        internal bool validatePaswordRule3(string? e)
        {
            throw new NotImplementedException();
        }

        public static string REGEX_MOBILENUMBER = "^[1-9]{2}[6-9]{1}[0-9]{9}$";


        // method for valid phone number
        public bool validateMobileNumber(string mnumber)
        {
            return Regex.IsMatch(mnumber, REGEX_MOBILENUMBER);
        }
        public static string REGEX_PASSWORDRULE1 = "^([a-zA-Z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9])*$";
        //method for paasword 
        public bool validatePaswordRule1(string prule1)
        {
            return Regex.IsMatch(prule1, REGEX_PASSWORDRULE1);
        }
         // method for passwordrule2
        public static string REGEX_PASSWORDRULE2 = "^([A-Z])*[!@#$%^&*]{1}([a-zA-Z0-9])*$"; //Arju@12

        public bool validatePaswordRule2(string prule2)
        {
            return Regex.IsMatch(prule2, REGEX_PASSWORDRULE2);
        }
        // method for passwordrule3
        public static string PASSWORD_RULE3_REGEX = "^([a-zA-Z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9])*$"; 
        public bool PasswordRule3(string prule3)
        {
            return Regex.IsMatch(prule3, PASSWORD_RULE3_REGEX);
        }
    }
}


    


