// W3Schools, C# Abstraction
using System;

namespace MyApplication
{
    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void AnimalSound();

        // Regular method
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.AnimalSound();    // Call the abstract method
            myPig.Sleep();          // Call the regular method
        }
    }
}