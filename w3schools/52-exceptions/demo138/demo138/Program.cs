// W3Schools, C# Exceptions
using System;

namespace MyApplication
{
    class Program
    {
        static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }
        static void Main(string[] args)
        {
            CheckAge(20);
        }
    }
}