using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;

namespace UC12_CustomException
{
    public class RegexPattern
    {
        public string message;
        public static string firstName;
        public static string lastName;
        public static string email;
        public static string phoneNum;
        public static string paasword;
        string pattern = "^[A-Z][a-z]{3,}$";

        public RegexPattern()
        {
            Console.WriteLine("Default Constructor");
        }
        public RegexPattern(string message)
        {
            this.message = message;
        }

        public void ValidatingAllFields()
        {
            Console.WriteLine("-----------## Validating all Fielsds##---------------");
            Regex regex = new Regex(pattern);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The First Name");
            Console.WriteLine("Enter the first name : ");
            string Firststname1 = Console.ReadLine();
            ValidateFirstName(Firststname1);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Last Name");
            Console.WriteLine("Enter the last name : ");
            string Lastname1 = Console.ReadLine();
            ValidateLastName(Lastname1);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Email Id");
            Console.WriteLine("Enter Email Id");
            string Email1 = Console.ReadLine();
            ValidateEmail(Email1);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Phone Number");
            Console.WriteLine("Enter the phone number");
            string number = Console.ReadLine();
            ValidatePhoneNum(number);
            Console.WriteLine("--------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Validating The Password");
            Console.WriteLine("Enter the password");
            string Pass = Console.ReadLine();
            ValidatePassWord(Pass);
        }
        public static string ValidateFirstName(string firstName)
        {
            string RegexRules = "^[A-Za-z]{3,}$";
            bool res = Regex.IsMatch(firstName, RegexRules);
            try
            {
                if (firstName.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "First name should not be empty");
                }
                if (firstName.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Last name should not be null");
                }
                if (res)
                {
                    Console.WriteLine("Valid");
                    return firstName;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "First should be valid"); throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "First should be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        }
        public static string ValidateLastName(string lastName)
        {
            string RegexRules = "^[A-Za-z]{3,}$";
            bool res1 = Regex.IsMatch(lastName, RegexRules); 
            try
            {
                if (lastName.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Last name should not be empty");
                }
                if (lastName.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Last name should not be null");
                }
                if (res1)
                {
                    Console.WriteLine("Valid");
                    return lastName;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Last name should be valid");
                }
                //return default;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        }
        public static string ValidateEmail(string email)
        {

            string RegexRules = (@"^[a-zA-Z0-9]+([\.\+\-][a-zA-Z0-9]+)?@[a-zA-Z0-9-]+(\.[a-zA-Z]{2,}(\.[a-zA-Z]+)?)$");
            bool result = Regex.IsMatch(email,RegexRules);
            try
            {
                if (email.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Email Id should not be empty");
                }
                if (email.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Email Id should not be null");
                }
                if (result)
                {
                    Console.WriteLine(email + " -----> Enter Email Valid");
                    return email;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Email Id valid");
                }            
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }

        }
        //uc-4 Validate Phone Number
        public static string ValidatePhoneNum(string phoneNum)
        {

            string[] phoneNumInput = { "91 7852234896", " 91 9865741548", "919865795312", "91@123", "A865" };
            string phoneNumPattern = @"^[0-9]+[\s]+[0-9]{10}$";
            Regex regex = new Regex(phoneNumPattern);

            bool result = regex.IsMatch(phoneNum);
            try
            {
                if (phoneNum.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MESSAGE, "Phone number should not be empty");
                }
                if (phoneNum.Equals(null))
                {
                    throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Phone number should not be null");
                }
                if (result)
                {
                    Console.WriteLine(phoneNum + " -----> number isValid");
                    return phoneNum;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.INVALID_MESSAGE, "Phone number should be valid");
                }
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        }
        public static string ValidatePassWord(string password)
        {
            string passwordPattern = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&:;<>,.?~_+-=(){}|]).{8,}$";

            Regex regex = new Regex(passwordPattern);

            bool result = regex.IsMatch(password);
            if (result)
            {
                Console.WriteLine("Password IS VAlid ");
                return password;
            }
            else
            {
                Console.WriteLine("Password Is --InValid");
            }

            return default;
        }
        //uc-9 clear all email samples
        public void ClearEmailAllPass()
        {
            string EmailAllSample = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            Regex regex = new Regex(EmailAllSample);
            string EmailAll = Console.ReadLine();
            bool res = regex.IsMatch(EmailAllSample);
            if (res)
            {
                Console.WriteLine("Email All Clear Passes");
            }
            else
            {
                Console.WriteLine("Enter A Email Again");
            }
        }
    }
}
