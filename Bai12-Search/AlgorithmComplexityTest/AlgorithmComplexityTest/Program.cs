using System;

namespace AlgorithmComplexityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string inputString = Console.ReadLine();

            int[] frequentChar = new int[255];
            for (int i = 0; i < inputString.Length; i++)
            {
                int ascii = (int)inputString[i];
                frequentChar[ascii] += 1;   
            }

            int max = 0;
            char character = (char)255;
            for (int j = 0; j < 255; j++)
            {
                if(frequentChar[j] > max)
                {
                    max = frequentChar[j];
                    character = (char)j;
                }
            }
            Console.WriteLine("The most appearing letter is '" + character + "' with a frequency of " + max + " times");
        }
    }
}
