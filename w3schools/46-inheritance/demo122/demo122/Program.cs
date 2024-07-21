// W3Schools, C# Inheritance
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();  // from the Car class

            myCar.honk();   // from the Vehicle class

            Console.WriteLine(myCar.brand + " " + myCar.modelName); // from Vehicle class and Car class
        }
    }
}