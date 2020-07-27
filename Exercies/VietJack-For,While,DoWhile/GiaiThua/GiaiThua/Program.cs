using System;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Action(number);
        }
        public static void Action(int number)
        {
            int k = 1;
            for (int i = 1; i <= number; i++)
            {
                k = k * i;
            }
            Console.WriteLine($"Giai thua cua {number} la {k}");
        }
    }
}
