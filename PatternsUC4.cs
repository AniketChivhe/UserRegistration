using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC4_ValidPhoneNumber
{
    internal class PatternsUC4
    {
        // Applying Regex Rule
        public static string RegexRules = @"^[0-9]+[\s]+[0-9]{10}$";
        
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
}
