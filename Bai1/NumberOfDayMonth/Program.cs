using System;

namespace NumberOfDayMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập tháng bạn muốn tìm số ngày : ");
            int month = Int32.Parse(Console.ReadLine());
            switch (month){
                case 2:
                Console.WriteLine("Tháng 2 có 28 hoặc 29 ngày");
                break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                Console.WriteLine("Tháng " + month + " có 31 ngày");
                break;
                case 4:
                case 6:
                case 9:
                case 11:
                Console.WriteLine("Tháng" + month + " có 30 ngày");
                break;
            }
        }
    }
}
