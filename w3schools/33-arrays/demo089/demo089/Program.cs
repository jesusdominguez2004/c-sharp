// W3Schools, C# Arrays, Multidimensional arrays
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}