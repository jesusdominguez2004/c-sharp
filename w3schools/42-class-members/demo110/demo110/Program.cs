// W3Schools, C# Class Members
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model + ":");
            Ford.fullThrottle();

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Opel.color + " " + Opel.year + " " + Opel.model + ":");
            Opel.fullThrottle();
        }
    }
}