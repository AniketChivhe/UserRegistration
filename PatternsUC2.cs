using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC2_ValidLastName
{
    internal class PatternsUC2
    {
        // Applying Regex Rule
        public static string RegexRules = "^[A-Za-z]{2,}$";
        
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
}
