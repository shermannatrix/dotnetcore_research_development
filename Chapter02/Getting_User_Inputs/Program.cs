﻿using System;

namespace Getting_User_Inputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your first name and press ENTER: ");
            string firstName = Console.ReadLine();
            Console.Write("Type your age and press ENTER: ");
            string age = Console.ReadLine();
            Console.WriteLine($"Hello {firstName}, you look good for {age}.");
        }
    }
}
