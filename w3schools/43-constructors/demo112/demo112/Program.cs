// W3Schools, C# Constructors
using System;

namespace MyApplication
{
    class Car
    {
        public string model;
        
        public Car(string modelName)
        {
            model = modelName;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang");
            Console.WriteLine(Ford.model);
        }
    }
}