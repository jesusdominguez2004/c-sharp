// W3Schools, C# Method Parameters, Default Parameter
using System;

namespace MyApplication
{
    class Program
    {
        // country is a parameter
        // Norway is the dedault parameter
        static void MyMethod(string country = "Norway")
        {
            Console.WriteLine(country);
        }

        // Sweden, India, Norway, USA are arguments
        static void Main(string[] args)
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod();
            MyMethod("Anja");
        }
    }
}