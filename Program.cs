
using System;

namespace UC5_ValidPassword
{
    class Program
    {
        public static void Main(string[] args)
        {
            PatternsUC5 patterns = new PatternsUC5();
            Console.WriteLine("Enter password minimum 8 characters");
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






