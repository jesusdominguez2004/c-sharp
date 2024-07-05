// W3Schools, C# Strings, Access Strings
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello";
            Console.WriteLine(myString[0]); // Outputs "H"
            Console.WriteLine(myString[1]); // Outputs "e"
            Console.WriteLine(myString[2]); // Outputs "l"
            Console.WriteLine(myString[3]); // Outputs "l"
            Console.WriteLine(myString[4]); // Outputs "o"

            Console.WriteLine(myString.IndexOf("H"));       // Outputs 0
            Console.WriteLine(myString.IndexOf("e"));       // Outputs 1
            Console.WriteLine(myString.IndexOf("l"));       // Outputs 2
            Console.WriteLine(myString.LastIndexOf("l"));   // Outputs 3
            Console.WriteLine(myString.IndexOf("o"));       // Outputs 4
        }
    }
}