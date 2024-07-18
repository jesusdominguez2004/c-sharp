// W3Schools, C# Constructors
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Car Opel = new Car("Astra", "White", 2005);

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
        }
    }
}