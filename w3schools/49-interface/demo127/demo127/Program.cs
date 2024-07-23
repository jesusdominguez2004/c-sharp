// W3Schools, C# Interface, Interface
using System;

namespace MyApplication
{
    // Interface
    interface IAnimal
    {
        void AnimalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal
    {
        // The body of AnimalSound()
        public void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.AnimalSound();
        }
    }
}