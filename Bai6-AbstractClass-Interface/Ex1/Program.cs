using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
           Pig quang = new Pig();
           quang.sleep();
           quang.animalSound(); 
        }
    }
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("ZzZzZzZz");
        }
    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Quang says : gau gau");
        }
    }
}
