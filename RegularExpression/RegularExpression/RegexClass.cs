using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class RegexClass
    {
        public static string NameRules = "^[A-Z]{1}[a-z]{2,}$";
        public static string LastNameRules = "^[A-Z]{1}[a-z]{2,}$";
        public static string EmailRules = "^[a-z]+[.+-_]{0,1}[0-9 a-z]+[@][a-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        public static string PhoneNumberRules = "^[0-9]{0,2}[+]{0,1}[8 9]{0,1}[0-9]{9}$";
        //public static string PasswordRules = "^[0-9 A-Z a-z]{8,}$";//UC5
        //Uc6
        public static string PasswordRules = "^([A - Z]{0,1})[0-9A-Za-z]{8,}$";

        public void ValidFirstName(string Name)
        {
            
            if (Regex.IsMatch(Name, NameRules))
                Console.WriteLine($"This is Valid Name:{Name}");
            else
                Console.WriteLine($"This is Invalid:{Name}");
        }
        public void ValidLastName(string LastName)
        {

            if (Regex.IsMatch(LastName, LastNameRules))
                Console.WriteLine($"This is Valid Name:{LastName}");
            else
                Console.WriteLine($"This is Invalid:{LastName}");
        }
        public void ValidEmail(string EmailCheck)
        {

            if (Regex.IsMatch(EmailCheck, EmailRules))
                Console.WriteLine($"This is Valid Email:{EmailCheck}");
            else
                Console.WriteLine($"This is Invalid Email:{EmailCheck}");
        }

        public void CheckPhoneNumber(string PhoneNumber)
        {
            if (Regex.IsMatch(PhoneNumber, PhoneNumberRules))
                Console.WriteLine($"This is Valid PhoneNumber:{PhoneNumber}");
            else
                Console.WriteLine($"This is Invalid PhoneNumber:{PhoneNumber}");

        }

        public void CheckPassword(string Password)
        {
            if (Regex.IsMatch(Password, PasswordRules))
                Console.WriteLine($"This is Valid Password:{Password}");
            else
                Console.WriteLine($"This is Invalid Password:{Password}");

        }
    }

}
