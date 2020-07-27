using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace BaiTapFile2
{
    class Bai2
    {
        const int MIN = 10;
        const int MAX = 70;
        static void Main(string[] args)
        {

            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = CreateMatrix(n, m);

            var path = @"C:\Users\Long\Documents\Module 2\Exercies\BaiTapFile\Bai2\data";
            var fileInput = "data.txt";
            var fileOutput = "out.txt";
            using (StreamWriter sw = File.CreateText($@"{path}\{fileInput}"))
            {
                sw.WriteLine($"{n} {m}");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        sw.Write($"{matrix[i, j]} "); 
                    }
                    sw.WriteLine();
                }
            }
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
                int[,] newMatrix = ConvertMatrix(data);
                int countEven = CountEven(newMatrix);
                sw.WriteLine($"The number of even numbers : {countEven}");
                int countMutiples = Mutiple(newMatrix);
                sw.WriteLine($"Number of numbers is a multiple of 5 : {countMutiples}");
            }
        }

        static int CountEven(int[,] matrix)
        {
            int count = 0;
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((matrix[i, j]) % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        static int Mutiple(int[,] matrix)
        {
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((matrix[i, j]) % 5 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
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
        static int[,] CreateMatrix(int row, int col)
        {
            Console.WriteLine("Gennerate Matrix........");
            int[,] matrix = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rnd.Next(MIN, MAX);
                    Console.Write($"{rnd.Next(MIN, MAX)} ");
                }
                Console.WriteLine();
            }
            return matrix;
        }
    }
}

