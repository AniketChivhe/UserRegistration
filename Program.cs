using System;

namespace UC3_ValidEmailID
{
    class Program
    {
        public static void Main(string[] args)
        {
            PatternsUC9 patterns = new PatternsUC9();
            Console.WriteLine("Various Email ID to check");
            Console.WriteLine("Enter 1 to check email id :- abc@yahoo.com");
            Console.WriteLine("Enter 2 to check email id :- abc-100@yahoo.com ");
            Console.WriteLine("Enter 3 to check email id :- abc.100@yahoo.com");
            Console.WriteLine("Enter 4 to check email id :- abc111@abc.com");
            Console.WriteLine("Enter 5 to check email id :- abc-100@abc.net");
            Console.WriteLine("Enter 6 to check email id :- abc.100@abc.com.au");
            Console.WriteLine("Enter 7 to check email id :- abc@1.com");
            Console.WriteLine("Enter 8 to check email id :- abc@gmail.com.com");
            Console.WriteLine("Enter 9 to check email id :- abc+100@gmail.com");

                int email = Convert.ToInt32(Console.ReadLine());
                switch (email)
                {
                    case 1:
                        if (patterns.validateString("abc@yahoo.com"))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 2:
                        if (patterns.validateString("abc-100@yahoo.com"))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 3:
                        if (patterns.validateString("abc.100@yahoo.com"))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 4:
                        if (patterns.validateString("abc111@abc.com"))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 5:
                        if (patterns.validateString("abc-100@abc.net"))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 6:
                        if (patterns.validateString("abc.100@abc.com.au"))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 7:
                        if (patterns.validateString("abc@1.com"))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 8:
                        if (patterns.validateString("abc@gmail.com.com"))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                            Console.WriteLine("Invalid");
                        break;
                    case 9:
                        if (patterns.validateString("abc+100@gmail.com"))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                            Console.WriteLine("Invalid");
                        break;
                }
                Console.ReadKey();
        }
    }
}






