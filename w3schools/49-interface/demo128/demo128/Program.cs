// W3Schools, C# Interface, Multiple Interfaces
using System;

namespace MyApplication
{
    interface IFirstInterface
    {
        void MyMethod();
    }

    interface ISecondInterface
    {
        void MyOtherMethod();
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("Some text...");
        }
        public void MyOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.MyMethod();
            myObj.MyOtherMethod();
        }
    }
}