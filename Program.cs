using System;

namespace UC2_ValidLastName
{
    class Program
    {
        public static void Main(string[] args)
        {
            PatternsUC2 patterns = new PatternsUC2();
            Console.WriteLine("Enter Valid Last Name ");
            string lastname = Console.ReadLine();

            if (patterns.validateString(lastname))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}






