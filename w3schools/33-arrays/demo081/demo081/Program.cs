// W3Schools, C# Arrays, Arrays
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create an array of four elements, and add values later
            string[] cars_1 = new string[4];
            Console.WriteLine(cars_1);

            // 2. Create an array of four elements and add values right away
            string[] cars_2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars_2);

            // 3. Create an array of four elements without specifying the size
            string[] cars_3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars_3);

            // 4. Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars_4 = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars_4);
        }
    }
}