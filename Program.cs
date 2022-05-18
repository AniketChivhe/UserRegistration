using System;

namespace UC1_ValidFirstName
{
    class Program
    {
        public static void Main(string[] args)
        {
            PatternsUC1 patterns = new PatternsUC1();
            Console.WriteLine("Enter Valid First Name");
            string firstname = Console.ReadLine();
            if (patterns.validateString(firstname))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}





