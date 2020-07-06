using System;

namespace VietJackCsharp
{
    class TestCsharp
    {
        public static void Main()
        {

            int[] arr1 = new int[10];
            int i, n, p, x;

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Nhap gia tri phan tu moi can chen: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vi tri can chen phan tu moi nay: ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("In mang ban dau:\n");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);
           
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];
            
            arr1[p - 1] = x;


            Console.Write("\n\nSau khi chen phan tu, mang co dang:\n");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n\n");     

            Console.ReadKey();
        } 
    }
}