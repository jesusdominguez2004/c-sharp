﻿// W3Schools, C# Enums
using System;

namespace MyApplication
{
    class Program
    {
        enum Months
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6
        }
        static void Main(string[] args)
        {
            int myNum = (int) Months.April;
            Console.WriteLine(myNum);
        }
    }
}