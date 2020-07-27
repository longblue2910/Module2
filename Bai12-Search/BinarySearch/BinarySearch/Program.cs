using System;
using System.Drawing;

namespace BinarySearch
{
    class Program
    {
        static int[] list = { 2, 4, 7, 10, 11, 45, 50, 59, 60, 66, 69, 70, 79 };
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(list, 2));       /* 0 */
            Console.WriteLine(BinarySearch(list, 11));     /* 4 */
            Console.WriteLine(BinarySearch(list, 79));     /*12 */
            Console.WriteLine(BinarySearch(list, 1));       /*-1 */
            Console.WriteLine(BinarySearch(list, 5));       /*-1 */
            Console.WriteLine(BinarySearch(list, 80));     /*-1 */

        }
        //static int[] CreateArray(int size)
        //{
        //    int[] array = new int[size];
        //    Random random = new Random();
        //    for (int i = 0; i < size; i++)
        //    {
        //        array[i] = random.Next(1, 20);
        //    }
        //    return array;
        //}
        //static void PrintArray(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        Console.Write($"{array[i]}\t");
        //    }
        //    Console.WriteLine();
        //}
        static int BinarySearch(int[] arr, int key)
        {
            int first = 0;
            int last = arr.Length - 1;
            while (last >= first)
            {
                int mid = (first + last) / 2;
                if (key < arr[mid])
                {
                    last = mid - 1;
                }
                else if (key == arr[mid])
                {
                    return mid;
                }
                else first = mid + 1;
            }
            return -1;
        }
    }
}
