using System;

namespace USDtoVND
{
    class Program
    {
        static void Main(string[] args)
        {
            double money;

            Console.WriteLine("Enter investment amount: ");
            money = Double.Parse(Console.ReadLine());
            double viet = money / 23000;
            Console.WriteLine(viet + "vnđ");


        }

    }
}
