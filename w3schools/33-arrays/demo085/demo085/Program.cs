// W3Schools, C# Arrays, Sort arrays
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Sort a string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sort a int
            int[] numbers = { 5, 1, 8, 9 };
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}