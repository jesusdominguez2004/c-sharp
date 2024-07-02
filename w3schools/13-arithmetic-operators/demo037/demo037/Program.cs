// W3Schools, C# Operators, Arithmetic
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;

            Console.WriteLine(x + y);
            Console.WriteLine(x - y);
            Console.WriteLine(x * y);
            Console.WriteLine(x / y);
            Console.WriteLine(x % y);

            x++;
            Console.WriteLine(x);

            x--;
            Console.WriteLine(x);
        }
    }
}