using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC7_AtLeastOneDigit
{
    internal class PatternsUC7
    {
        // Applying Regex Rule
        public static string RegexRules = @"^(?=.*[A-Z]).{8,}[0-9]$";   
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
}
