

using System;

namespace UC8_OneSpecialChar
{
    class Program
    {
        public static void Main(string[] args)
        {
            PatternsUC8 patterns = new PatternsUC8();
            Console.WriteLine("Enter password minimum 8 characters with one upper case and one numeric number and special charactor");
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








