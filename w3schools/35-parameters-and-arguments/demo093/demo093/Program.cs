// W3Schools, C# Method Parameters, Parameters & Arguments
using System;

namespace MyApplication
{
    class Program
    {
        // fname is a parameter
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        // Liam, Jenny, Anja are arguments
        static void Main(string[] args)
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");
        }
    }
}