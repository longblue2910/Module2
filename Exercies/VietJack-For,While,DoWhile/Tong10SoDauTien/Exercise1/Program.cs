using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, sum = 0;

            Console.Write("\n");
            Console.Write("Tinh tong day so trong C#:\n");
            Console.Write("-----------------------------");
            Console.Write("\n\n");

            Console.Write("10 so tu nhien dau tien la:\n");
            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write($"{j}\t");
            }
            Console.Write($"\nTong cua 10 so tren la: {sum}");

            Console.ReadKey();
        }
    }
}
