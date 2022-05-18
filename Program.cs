using System;

namespace UC3_ValidEmailID
{
    class Program
    {
        public static void Main(string[] args)
        {
            PatternsUC3 patterns = new PatternsUC3();
            Console.WriteLine("Enter Valid Email ID");
            string email = Console.ReadLine();
            if (patterns.validateString(email))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}






