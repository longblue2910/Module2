using System;

namespace BangCuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            #region For
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");

                }
                Console.WriteLine();
            }
            #endregion

            #region While
            int first, last;
            first = 2;
            while (first <= 9)
            {
                last = 1;
                while (last <= 10)
                {
                    Console.WriteLine($"{first} x {last} = {first * last}");
                    last++;
                }
                Console.WriteLine();
                first++;
            }
            #endregion

            #region Do-While
            int SoNhan = 2; int SoDuocNhan;
            do
            {
                SoDuocNhan = 1;
                do
                {
                    Console.WriteLine($"{SoNhan} x {SoDuocNhan} = {SoNhan*SoDuocNhan}");
                    SoDuocNhan++;
                } while (SoDuocNhan <= 10);
                Console.WriteLine();
                SoNhan++;
            } while (SoNhan <= 9);
            #endregion
        }
    }
}
