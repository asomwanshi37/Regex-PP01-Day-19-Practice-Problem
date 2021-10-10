using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Day19
{
    class UC2
    {
        public string RegexPattern = "^[A-Z]{3}[a-z]*$";

        public bool LastNameCheck(string LastName)
        {
            return Regex.IsMatch(LastName, RegexPattern);
        }

    }
}
