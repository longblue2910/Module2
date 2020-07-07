using System;

namespace XoaPhanTU
{
    class XoaPhanTU1
    {
        public static void Main()
        {

            int i, pos, n;
            int[] arr1 = new int[50];


            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
          
            Console.Write("Nhap {0} phan tu vao mang theo thu tu tang dan:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nNhap vi tri can xoa: ");
            pos = Convert.ToInt32(Console.ReadLine());
           
            i = 0;
            while (i != pos - 1)
                i++;
            
            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;
            Console.Write("\nIn mang sau khi da xoa phan tu: ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");      

            Console.ReadKey();
        } 
    }
}