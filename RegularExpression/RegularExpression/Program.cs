using System;
using System.Net.Security;

namespace RegularExpression
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("hello regex problem UC-7(Password)");

            //Console.WriteLine("Enter your Name, Check valid or not");
            //string TakeName = Console.ReadLine();
            RegexClass regexClass = new RegexClass();
            //regexClass.ValidFirstName(TakeName);


            //Console.WriteLine("Enter your LastName, Check valid or not");
            //string TakeLastName = Console.ReadLine();
            //regexClass.ValidLastName(TakeLastName);

            //Console.WriteLine($"Your Full Name: {TakeName} {TakeLastName}");


            //Console.WriteLine("Enter your Email, CheckEmail valid or not");
            //string Email = Console.ReadLine();
            //regexClass.ValidEmail(Email);


            //Console.WriteLine("Enter your Phone number, and check valid or not");
            //string TakeNumber = Console.ReadLine();
            //regexClass.CheckPhoneNumber(TakeNumber);


            Console.WriteLine("Enter your Password, Check password valid or not");
            string Password = Console.ReadLine();
            regexClass.CheckPassword(Password);


            Console.WriteLine("valid Email Here \n");
            string[] Emails = { "abc@gamil.com", "abc-1123@gamail.com", "abc.100@gmail.com", "abc11@abc.in", "abc-100@abc.in", "abc.100@abc.com.in", "abc@er.com" };
            foreach (string EmailType in Emails)
            {
                regexClass.ValidEmail(EmailType);
            }

        }
    }
}