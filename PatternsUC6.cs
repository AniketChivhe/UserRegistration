using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC6_PasswordUpperCase
{
    internal class PatternsUC6
    {
        // Applying Regex Rule
        public static string RegexRules = @"^(?=.*[A-Z]).{8,}$";
        
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
}
