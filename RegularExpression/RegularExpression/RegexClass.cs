﻿using System;
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
        public void ValidFirstName(string Name)
        {
            
            if (Regex.IsMatch(Name, NameRules))
                Console.WriteLine($"This is Valid Name:{Name}");
            else
                Console.WriteLine($"This is Invalid:{Name}");
        }
    }

}