// W3Schools, C# Strings, Special Characters
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt1 = "Hello\nWorld!";
            string txt2 = "Hello\tWorld!";
            string txt3 = "Hel\blo World!";

            Console.WriteLine(txt1);
            Console.WriteLine(txt2);
            Console.WriteLine(txt3);
        }
    }
}