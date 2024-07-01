// W3Schools, C# Type Casting
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDouble = 9.78;   
            int myInt = (int) myDouble;     // Manual casting: double to int

            Console.WriteLine(myDouble);    // Outputs 9.78
            Console.WriteLine(myInt);       // Outputs 9
        }
    }
}