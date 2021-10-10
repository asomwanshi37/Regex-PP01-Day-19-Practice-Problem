using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Day19
{
    class UC1
    {
        public string RegexPattern = "^[A-Z]{3}[a-z]*$";

        public bool FirstNameCheck(string FirstName)
        {
            return Regex.IsMatch(FirstName, RegexPattern);
        }

    }
}
