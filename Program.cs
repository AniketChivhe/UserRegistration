
using System;

namespace UC6_PasswordUpperCase
{
    class Program
    {
        public static void Main(string[] args)
        {
            PatternsUC6 patterns = new PatternsUC6();
            Console.WriteLine("Enter password minimum 8 characters with one upper case");
            string password = Console.ReadLine();
            if (patterns.validateString(password))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}







