// W3Schools, C# Operators, Logical
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            Console.WriteLine(x < 5 && x < 10);     // Logical and (returns True)
            Console.WriteLine(x < 5 || x < 4);      // Logical or  (returns True)
            Console.WriteLine(!(x < 5 && x < 10));  // Logical not (returns False)
        }
    }
}