using System;

namespace VeTamGiacCan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Row: ");
            int row = int.Parse(Console.ReadLine());
            DrawStriangle(row);
        }
        public static void DrawStriangle(int row)
        {
            int count = row + 4 - 1;
            int t = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int k = count; k >= 1; k--)
                {
                    Console.WriteLine(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine($"{t++}");
                }
                Console.WriteLine("\n");
                count--;
            }    
        }
    }
}
