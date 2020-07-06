using System;

namespace indexBody
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weight;
            Console.WriteLine("Nhập chiều cao : ");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều cân nặng : ");
            weight = float.Parse(Console.ReadLine());

            double indexBmi = weight / Math.Pow(height, 2);
            indexBmi = Math.Round(indexBmi, 1);
            Console.WriteLine("Chỉ số BMI của cơ thể là : " + indexBmi);
            if (indexBmi < 18)
            {
                Console.WriteLine("Thiếu cân");
            }
            else if (indexBmi < 25)
            {
                Console.WriteLine("Chuẩn");
            }
            else if (indexBmi < 30){
                Console.WriteLine("Thừa cân");
            }
            else
            {
                Console.WriteLine("Béo Phì");
            }
        }
    }
}
