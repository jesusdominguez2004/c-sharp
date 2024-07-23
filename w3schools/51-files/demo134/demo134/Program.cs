// W3Schools, C# Files
using System;
using System.IO;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello World!";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);
        }
    }
}