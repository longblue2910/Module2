using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            float width;
            float height;
            Console.Write("Enter width : ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter Height : ");
            height = float.Parse(Console.ReadLine());
            float are = width * height;
            Console.WriteLine("Are is : " + are);
        }
    }
}
