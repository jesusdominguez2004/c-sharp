// W3Schools, C# Type Casting
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // some built-in methods
            int myInt = 30;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));     // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));     // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));   // convert double to int
            Console.WriteLine(Convert.ToString(myBool));    // convert bool to string
        }
    }
}