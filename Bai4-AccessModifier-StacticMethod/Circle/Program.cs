using System;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle Tron1 = new Circle();
            Tron1.SetRadius(1);
            Tron1.SetColor("black");
            Console.WriteLine(Tron1.GetColor());
            Console.Write(Tron1.GetRadius());
        }
    }
}
