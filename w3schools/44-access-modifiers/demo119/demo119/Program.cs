﻿// W3Schools, C# Access Modifiers
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj);
            // Console.WriteLine(myObj.model); ERROR
            // Console.WriteLine(myObj.color); ERROR
        }
    }
}