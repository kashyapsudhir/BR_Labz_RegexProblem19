using System;
using System.Net.Security;

namespace RegularExpression
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("hello regex problem UC-1");

            Console.WriteLine("Enter your Name, Check valid or not");
            string TakeName = Console.ReadLine();
            RegexClass regexClass = new RegexClass();
            regexClass.ValidFirstName(TakeName);
          
        }
    }
}