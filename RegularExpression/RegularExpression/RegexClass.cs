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
    }

}
