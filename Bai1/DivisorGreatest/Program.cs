using System;

namespace DivisorGreatest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 || b == 0)
                Console.WriteLine("Không có ước số chung lớn nhất : ");
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine("Ước số chung lớn nhât là : " + a);
        }
    }
}
