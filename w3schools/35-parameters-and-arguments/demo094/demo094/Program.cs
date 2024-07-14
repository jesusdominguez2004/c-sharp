// W3Schools, C# Method Parameters, Parameters & Arguments
using System;

namespace MyApplication
{
    class Program
    {
        // fname is a parameter
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        // Liam, Jenny, Anja are arguments
        static void Main(string[] args)
        {
            MyMethod("Liam", 5);
            MyMethod("Jenny", 8);
            MyMethod("Anja", 31);
        }
    }
}