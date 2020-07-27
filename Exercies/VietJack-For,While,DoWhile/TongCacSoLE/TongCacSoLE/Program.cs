using System;
using System.Globalization;

namespace TongCacSoLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of the first odd and even number: ");
            int number = int.Parse(Console.ReadLine());
            SumOdd(number);
            SumEven(number);
        }
        #region Sum Odd
        public static void SumOdd(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{2 * i - 1}");
                sum += 2 * i - 1;
            }
            Console.WriteLine($"Sum Odd : {sum}");
        }
        #endregion

        #region Sum Ever
        public static void SumEven(int number)
        {
            int sumeven = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{2 * i}");
                sumeven += 2 * i;
            }
            Console.WriteLine($"Sum Even : {sumeven}");

        }
        #endregion
    }
}
