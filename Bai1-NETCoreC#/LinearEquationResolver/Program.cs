using System;

namespace LinearEquationResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giải phương trình bậc nhất");
            Console.WriteLine("Cho phương bình là 'a * x + b = 0', vui lòng nhập a, b để tìm nghiệm");
            Console.Write("a: " );
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: " );
            double b = Convert.ToDouble(Console.ReadLine());
            if (a != 0){
                double x = -b/a;
                Console.WriteLine("Nghiệm phương trình là : " + x);
            }
            else  {
                if (b == 0){
                    Console.WriteLine("Phương trình số nghiệm");
                }
                else{
                    Console.WriteLine("Phương trình vô nghiệm");
                }
            }
        }
    }
}
