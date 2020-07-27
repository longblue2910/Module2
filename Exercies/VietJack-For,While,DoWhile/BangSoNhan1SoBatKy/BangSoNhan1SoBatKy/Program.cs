using System;

namespace BangSoNhan1SoBatKy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            RandomNumber(number);
        }
        public static void RandomNumber(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }    
        }
    }
}
