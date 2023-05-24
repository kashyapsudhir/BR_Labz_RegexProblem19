﻿using System;
using System.Net.Security;

namespace RegularExpression
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to User Registration Problem");
            Console.WriteLine("hello regex problem UC-6(Password)");

            Console.WriteLine("Enter your Name, Check valid or not");
            string TakeName = Console.ReadLine();
            RegexClass regexClass = new RegexClass();
            regexClass.ValidFirstName(TakeName);


            Console.WriteLine("Enter your LastName, Check valid or not");
            string TakeLastName = Console.ReadLine();
            regexClass.ValidLastName(TakeLastName);

            Console.WriteLine($"Your Full Name: {TakeName} {TakeLastName}");


            Console.WriteLine("Enter your Email, CheckEmail valid or not");
            string Email = Console.ReadLine();
            regexClass.ValidEmail(Email);


            Console.WriteLine("Enter your Phone number, and check valid or not");
            string TakeNumber = Console.ReadLine();
            regexClass.CheckPhoneNumber(TakeNumber);


            Console.WriteLine("Enter your Password, Check password valid or not");
            string Password = Console.ReadLine();
            regexClass.CheckPassword(Password);

        }
    }
}