using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig quang = new Pig();
            quang.animalSound();
            quang.animalEat();
            quang.animalMore();
        }
    }
    interface IAnimal
    {
        void animalSound()
        {}
    }
    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The Quang says : wee wee");
        }
        public void animalEat()
        {
            Console.WriteLine("The Quang eat 50kg meat everyday but not full");
        }
        public void animalMore()
        {
            Console.WriteLine("Quang rat thich choi ngu");
        }
    }
}
