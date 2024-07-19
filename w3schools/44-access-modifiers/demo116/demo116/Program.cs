// W3Schools, C# Access Modifiers
using System;

namespace MyApplication
{
    class Car
    {
        private string model = "Mustang";

        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.model);
        }
    }
}