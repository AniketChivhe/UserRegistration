using System;

namespace UC11_UsingReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Validating using Regular Expression!");
            RegexPattern regexPattern = new RegexPattern();
            regexPattern.Validating();
        }
    }
}