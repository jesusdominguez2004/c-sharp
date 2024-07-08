// W3Schools, C# If...Else, Short hand if...else
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable = (condition) ? expressionTrue : expressionFalse;
            int time = 20;
            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}