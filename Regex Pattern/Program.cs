﻿using System;
namespace RegexPattern
{
    class program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            //Console.WriteLine(pattern.validateFirstName("Arjun"));
            //Console.WriteLine(pattern.validateLastName("Jaiswal"));
           // string a = Console.ReadLine();

            //Console.WriteLine(pattern.valiadtaeEmail(a));
            string b = Console.ReadLine();
            Console.WriteLine(pattern.validateMobileNumber(b));
        }
    }
    

}    

