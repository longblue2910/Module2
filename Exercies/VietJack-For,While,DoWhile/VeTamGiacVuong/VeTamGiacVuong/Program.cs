using System;

namespace VeTamGiacVuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Row: ");
            int row = int.Parse(Console.ReadLine());
            DrawTriangelStar(row);
            DrawTriangleNumber(row);
            DrawTriangleNumber2(row);
            DrawTriangleNumber3(row);
        }

        public static void DrawTriangelStar(int row)
        {
            for (int i = 1; i <= row; i++)
            {
                for ( int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }    
        }
        public static void DrawTriangleNumber(int row)
        {
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}");
                }
                Console.Write("\n");
            }
        }
        public static void DrawTriangleNumber2(int row)
        {
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}");
                }
                Console.Write("\n");
            }
        }
        public static void DrawTriangleNumber3(int row)
        {
            int k = 0;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{k++}");
                }
                Console.Write("\n");
            }
        }
    }
}
