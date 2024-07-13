// W3Schools, C# Arrays, Sort arrays
using System;
using System.Linq;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Min, Max, and Sum, can be found in the System.Linq namespace:
            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max()); // returns the largest value
            Console.WriteLine(myNumbers.Min()); // returns the smallest value
            Console.WriteLine(myNumbers.Sum()); // returns the sum of elements
        }
    }
}