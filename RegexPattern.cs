using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UC11_UsingReflection
{
    public class RegexPattern
    {
        public string message;
        public static string email;
        

        public RegexPattern()
        {
            Console.WriteLine("Default Constructor");
        }
        public RegexPattern(string message)
        {
            this.message = message;
        }
        public void Validating()
        {
            
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input = Console.ReadLine();
            ValidatingEmailId(input);
            
        }

        public static string ValidatingEmailId(string email)
        {

            string RegexRules = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            bool result = Regex.IsMatch(email, RegexRules);
            try
            {
                if (email.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Email Id should not be empty");
                }
                if (email.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Email Id should not be null");
                }
                if (result)
                {
                    Console.WriteLine(email + " ----->Valid");
                    return email;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Email Id should be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }

        }
    }
       
}
