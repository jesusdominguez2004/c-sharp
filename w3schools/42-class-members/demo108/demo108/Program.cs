// W3Schools, C# Class Members
using System;

namespace MyApplication
{
    class Car
    {
        string color;               // field
        int maxSpeed;               // field
        public void fullThrottle()  // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.fullThrottle();   // call the method
        }
    }
}