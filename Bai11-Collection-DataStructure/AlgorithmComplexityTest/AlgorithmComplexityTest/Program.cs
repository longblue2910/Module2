using System;

namespace AlgorithmComplexityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String : ");
            String inputString = Console.ReadLine();

            int[] frequentChar = new int[255];
            
            for (int i = 0; i < inputString.Length; i++)
            {
                
                /* Tìm ví trí tương ứng của ký tự trong bảng ASCII */
                int ascii = (int)inputString[i];
                
                /* Tăng giá trị tần suất */
                frequentChar[ascii] += 1;
                
            }
        }
    }
}
