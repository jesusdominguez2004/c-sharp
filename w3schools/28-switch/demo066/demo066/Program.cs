// W3Schools, C# Switch
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 4;
            switch (day)
            {
                case 6:
                    Console.WriteLine("Saturday.");
                    break;
                case 7:
                    Console.WriteLine("Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
        }
    }
}