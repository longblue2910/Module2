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
        public int SumEven(int matrix[,])
        {
            for (int i = 0; i < matrix.GetL)
        }
    }
}
