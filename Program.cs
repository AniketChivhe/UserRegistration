using System;

namespace UC4_ValidPhoneNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            PatternsUC4 patterns = new PatternsUC4();
            Console.WriteLine("Enter Valid Phone number with country code");
            string phoneNo = Console.ReadLine();
            if (patterns.validateString(phoneNo))
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}






