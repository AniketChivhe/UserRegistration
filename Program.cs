using System;

namespace UC10_UnitTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("User Registration Validating using Regular Expression!");
            RegexPattern regexPattern = new RegexPattern();
                regexPattern.Validating();
        }
    }
}