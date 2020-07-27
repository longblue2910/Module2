using System;

namespace KiemTraSoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kiem tra so nguyen to trong C#:\n");
            Console.WriteLine("----------------------------");
            Console.Write("Nhap mot so bat ky: ");
            int number = Convert.ToInt32(Console.ReadLine());
            IsPrime(number);
        }
        public static void IsPrime(int number)
        {
            int bien_dem = 0;
            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    bien_dem++;

            if (bien_dem == 2)
                Console.WriteLine("So da cho la so nguyen to.");
            else
                Console.WriteLine("So da cho khong phai la so nguyen to.");
            Console.ReadKey();
        }
    }
}
