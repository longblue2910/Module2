using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Search_Sort
{
    public class SearchSort
    {
        public int[] CreateArray(int n)
        {
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(30, 60);
            }
            return array;
        }

        public bool IsSymmetryArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n/2; i++)
            {
                if (array[i] != array[n - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        public int[] SelectionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
            return array;
        }  
        public int BinarySearch(int[] array, int key)
        {
            int first = 0;
            int last = array.Length - 1;
            while (last >= first)
            {
                int mid = (first + last) / 2;
                if (key < array[mid])
                {
                    last = mid - 1;
                }
                else if (key == array[mid])
                {
                    return mid;
                }
                else first = mid + 1;
            }
            return -1;
        }
    }
}
