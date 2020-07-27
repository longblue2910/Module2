using System;
using System.Dynamic;

namespace Search_Sort
{
    class Program
    {
        public static int[] arr = new int[0];
        public static SearchSort searchSort = new SearchSort();
        static void Menu()
        {
            Console.WriteLine("1. Create Array");
            Console.WriteLine("2. Check Symetric Array");
            Console.WriteLine("3. Selection Sort");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Exit");
        }
        static void Main(string[] args)
        {
            int choice;
            Menu();
            while (true)
            {

                Console.WriteLine("Please select an item: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter size array :");
                        int n = int.Parse(Console.ReadLine());
                        arr = searchSort.CreateArray(n);
                        PrintArray(arr);
                        break;
                    case 2:
                        if (searchSort.IsSymmetryArray(arr))
                        {
                            Console.WriteLine("The upper array is a symmetrical array");
                        } 
                        else
                        Console.WriteLine("The upper array is not a symmetrical array");
                        break;
                    case 3:
                        arr = searchSort.SelectionSort(arr);
                        PrintArray(arr);
                        break;
                    case 4:
                        arr = searchSort.SelectionSort(arr);
                        Console.WriteLine("Enter the number to search");
                        int number = int.Parse(Console.ReadLine());
                        int index;
                        index = searchSort.BinarySearch(arr, number);
                        if (index == -1)
                        {
                            Console.WriteLine("Number is not in the array");
                        }
                        else Console.WriteLine("Number is in the array");
                        break;
                    case 5:
                        Console.WriteLine("Bye Bye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not found");
                        break;
                }
            }
        }
        public static void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
