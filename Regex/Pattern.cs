using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    public class Pattern
    {
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[A-Za-z]{2,}$"; 

        //Method For Validate First Name
        public bool validateFirstName(string fname)
        {
            return IsMatch(fname, FIRST_NAME_REGEX);
        }

        private bool IsMatch(string fname, string fIRST_NAME_REGEX)
        {
            throw new NotImplementedException();
        }
    }
}

