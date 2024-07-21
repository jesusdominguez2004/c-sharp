// W3Schools, C# Inheritance
using System;

namespace MyApplication
{
    sealed class Vehicle
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }
}