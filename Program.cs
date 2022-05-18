
    
using System;

namespace UC7_AtLeastOneDigit
{
    class Program
    {
        public static void Main(string[] args)
        {
            PatternsUC7 patterns = new PatternsUC7();
            Console.WriteLine("Enter password minimum 8 characters with one upper case and one numeric number");
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







