using System;

namespace BinarySearchRecursive
{
    class Program
    {
        static int[] list = { 2, 4, 7, 10, 11, 45, 50, 59, 60, 66, 69, 70, 79 };
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(list, 0, list.Length-1, 11));       
        }
        static int BinarySearch(int[] arr, int first, int last, int value)
        {
            if (last >= first)
            {
                int mid = (first + last) / 2;
                if (arr[mid] == value)
                {
                    return mid;
                }
                if(arr[mid] > value)
                {
                    return BinarySearch(arr, first, mid - 1, value); 
                }
                return BinarySearch(arr, mid + 1, last, value);
            }
            return -1;
        }
    }
}
