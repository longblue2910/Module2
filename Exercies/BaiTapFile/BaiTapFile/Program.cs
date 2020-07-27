using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace BaiTapFile
{
    class Program
    {
        const int ROW = 5;
        const int COLUMS = 10;
        const int MIN = 1;
        const int MAX = 5;

        static void Main(string[] args)
        {
            var path = @"C:\Users\Long\Documents\Module 2\Exercies\BaiTapFile\BaiTapFile\data";
            //Directory.CreateDirectory(path);

            var fileInput = "input.txt";
            var fileOutput = "output.txt";
            //using (StreamWriter sw = File.CreateText($@"{path}\{fileInput}"))
            //{
            //    sw.WriteLine($"{ROW} {COLUMS}");
            //    Random rnd = new Random();
            //    int value;
            //    for (int i = 0; i < ROW; i++)
            //    {
            //        for (int j = 0; j < COLUMS; j++)
            //        {
            //            sw.Write($"{rnd.Next(MIN, MAX)} ");
            //        }
            //        sw.WriteLine();
            //    }
            //}
            List<string> data = new List<string>();
            using (StreamReader sr = File.OpenText($@"{path}\{fileInput}"))
            {
                var line = string.Empty;
                int number = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    number += 1;
                    Console.WriteLine($"Line {number} : {line.ToUpper()} ");
                    data.Add(line);
                }
            }
            using (StreamWriter sw = File.CreateText($@"{path}\{fileOutput}"))
            {
                sw.WriteLine("Out put");
                for (int i = 1; i < data.Count; i++)
                {
                    sw.WriteLine($"{data[i]}");
                }
                int[,] matrix = ConvertMatrix(data);
                int sumMatrix = SumMatrix(matrix);
                sw.WriteLine($"Sum Matrix : {sumMatrix}");
                int countPrime = CountPrime(matrix);
                sw.WriteLine($"The matrix have {countPrime} prime");
                int oddCount = CountOdd(matrix);
                sw.WriteLine($"The matrix have {oddCount} odd");
                int sumBorderLine = SumBorderMatrix(matrix);
                sw.WriteLine($"Sum Border Line Matrix : {sumBorderLine}");
                int[,] newMatrix = MultiplyMatrix(matrix, 3);
                PrinMatrix(newMatrix, sw);
            }
        }


        static int[,] ConvertMatrix(List<string> data)
        {
            string[] arrRowColum = data[0].Split(" ");
            int row = int.Parse(arrRowColum[0]);
            int col = int.Parse(arrRowColum[1]);
            int[,] matrix = new int[row, col];
            int indexRow = 0;
            for (int i = 1; i < data.Count; i++)
            {
                string[] arr = data[i].Split(" ");
                for (int indexCoL = 0; indexCoL < matrix.GetLength(1); indexCoL++)
                {
                    matrix[indexRow, indexCoL] = int.Parse(arr[indexCoL]);
                }
                indexRow++;
            }
            return matrix;
        }

        static int SumMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;
            else
            {
                int i = 2;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                    i++;
                }
            }
            return true;
        }
        static int CountPrime(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (IsPrime(matrix[i, j]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static int CountOdd(int[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static int SumBorderMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[0, j];
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[matrix.GetLength(0) - 1, j];
            }
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                sum += matrix[i, 0];
            }
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                sum += matrix[i, matrix.GetLength(1) - 1];
            }
            return sum;
        }
        static int[,] MultiplyMatrix(int[,] matrix, int value)
        {
            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                   newMatrix[i, j] = matrix[i, j] * value;
                }
            }
            return newMatrix;
        }

        static void PrinMatrix(int[,] matrix, StreamWriter sw)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sw.Write($"{matrix[i, j]}\t");
                }
                sw.WriteLine();
            }
        }
    }
}
