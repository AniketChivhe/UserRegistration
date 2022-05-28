using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UC9_EmailCheck
{
    public class EmailTest
    {
        public static string ValidatingEmailId(string email)
        {
            string RegexRules = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");   
            bool result = Regex.IsMatch(email, RegexRules);
            if (result)
            {
                Console.WriteLine(email + " ----->Valid");
                return email;
            }
            else
            {
                Console.WriteLine(email + " ----->Invalid");
            }
            return default;
        }
    }
}
