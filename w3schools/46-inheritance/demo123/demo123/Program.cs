// W3Schools, C# Inheritance
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myObj = new Vehicle();
            myObj.honk();
            Console.WriteLine(myObj.brand);
        }
    }
}