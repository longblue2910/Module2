using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoClass QuangPig = new DemoClass();
            QuangPig.myMethod();
            QuangPig.myOtherMethod();
        }
    }
    interface IFirstInterFace
    {
        void myMethod();
    }
    interface ISecondInterFace
    {
        void myOtherMethod();
    }
    class DemoClass : IFirstInterFace, ISecondInterFace
    {
        public void myMethod()
        {
            Console.WriteLine("The Quang says : Ewww ewwww");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("The Quang eat same Pig");
        }
    }
}
