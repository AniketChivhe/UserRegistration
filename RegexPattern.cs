using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UC10_UnitTest
{
    public class RegexPattern
    {
        public void Validating()
        {       
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The First Name");
            Console.WriteLine("Enter the first name : ");
            string input = Console.ReadLine();
            ValidatingFirstName(input);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Last Name");
            Console.WriteLine("Enter the last name : ");
            string input1 = Console.ReadLine();
            ValidatingLastName(input1);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string input2 = Console.ReadLine();
            ValidatingEmailId(input2);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Phone Number with contry Code");
            Console.WriteLine("Enter the phone number");
            string input3 = Console.ReadLine();
            ValidatingPhoneNum(input3);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Password");
            Console.WriteLine("Enter the password");
            string input4 = Console.ReadLine();
            ValidatingPassWord(input4);

        }

        public static string ValidatingFirstName(string firstName)
        {
            string RegexRules = "^[A-Za-z]{3,}$";
            bool res = Regex.IsMatch(firstName, RegexRules);
            if (res)
            {
                Console.WriteLine("Valid");
                return firstName;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;
        }
        public static string ValidatingLastName(string lastName)
        {
            string RegexRules = "^[A-Za-z]{3,}$";  
            bool res1 = Regex.IsMatch(lastName, RegexRules);
            if (res1)
            {
                Console.WriteLine("Valid");
                return lastName;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            return default;
        }
        public static string ValidatingEmailId(string email)
        {
            string RegexRules = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            bool result = Regex.IsMatch(email, RegexRules);
            if (result)
            {
                Console.WriteLine(email + " ----->Valid");
                return email;
            }
            else
            {
                Console.WriteLine(email + " ----->Invalid");
            }
            return default;
        }

        public static string ValidatingPhoneNum(string phoneNum)
        {
           // string[] phoneNumInput = { "91 7852234896", " 91 9865741548", "919865795312", "91@123", "A865" };
            string RegexRules = "^[0-9]+[ ]+[0-9]{10}$";

            bool result = Regex.IsMatch(phoneNum, RegexRules);
            if (result)
            {
                Console.WriteLine(phoneNum + " ----->Valid");
                return phoneNum;
            }
            else
            {
                Console.WriteLine(phoneNum + " ----->InValid");
            }
            return default;
        }
        public static string ValidatingPassWord(string password)
        {
            //string[] passwordInput = { "Shalini@12", "sakAthi_32", "raksha123", "prathee" };
            string RegexRules = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&:;<>,.?~_+-=(){}|]).{8,}$";

            bool result = Regex.IsMatch(password, RegexRules);
            if (result)
            {
                Console.WriteLine(password + " ----->Valid");
                return password;
            }
            else
            {
                Console.WriteLine(password + " ----->InValid");
            }
            return default;
        }
    }
}
