﻿using System;
using static System.Console;

namespace IfPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = 3;
            int j = 4;

            if (o is int i) {
                WriteLine($"{i} x {j} = {i * j}");
            } else {
                WriteLine($"o is not an int so it cannot multiply!");
            }
        }
    }
}
