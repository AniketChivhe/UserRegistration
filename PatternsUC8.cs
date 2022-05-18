using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC8_OneSpecialChar
{
    internal class PatternsUC8
    {
        // Applying Regex Rule
        public static string RegexRules = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&:;<>,.?~_+-=(){}|]).{8,}$";
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
}
