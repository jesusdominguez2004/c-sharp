// W3Schools, C# Method Parameters, Return Values
using System;

namespace MyApplication
{
    class Program
    {
        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int z = MyMethod(5, 3);
            Console.WriteLine(z);
        }
    }
}