using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Method
{
    class Exercise1
    {
        public int[,] CreateMatrix (int n)
        {
            int[,] matrix = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    matrix[i, k] = random.Next(10, 90);
                }    
            }
            return matrix;
        }
        public int SumEven(int[,] matrix) 
        {
            int sum = 0;
            for ( int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] % 2 == 0)
                    {
                        sum += matrix[i, k];
                    }    
                }
            }
            return sum;
        }
        public int SumMainCross(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }
        public int SumDiagonalFiller(int[,] matrix)
        {
            int sum = 0, m = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                m = m - 1;
                for (int k = 0; i < matrix.GetLength(0); k++)
                {
                    if (k == m)
                    {
                        sum += matrix[i, k];
                    }    
                }    
            }
            return sum;
        }
        public int SumTotalBoundary(int[,] matrix)
        {
           
        }
    }
}
