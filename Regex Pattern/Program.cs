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
            //string b = Console.ReadLine();
            //Console.WriteLine(pattern.validateMobileNumber(b));

            //string c = Console.ReadLine();
            //Console.WriteLine(pattern.validatePaswordRule1(c));

            string d = Console.ReadLine();
            Console.WriteLine(pattern.validatePaswordRule2(d));
        }
    }
}

    

   

