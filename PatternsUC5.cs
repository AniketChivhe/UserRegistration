using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC5_ValidPassword
{
    internal class PatternsUC5
    {
        // Applying Regex Rule
        public static string RegexRules = @"[a-z,A-Z,0-9]{8,}$";
        
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
}
