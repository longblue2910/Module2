using System;

namespace Ex7
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("1. Add new Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Interate Product");
            Console.WriteLine("4. Search Product");
            Console.WriteLine("5. Exit");
        }
        static void Main(string[] args)
        {
            int choice;
            Shop rimstore = new Shop();
            Menu();
            while(true)
            {
                Console.Write("Please choose an item: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                   case 1:
                   Product p = new Product();
                   rimstore.addProduct(p);
                   break;
                   case 2:
                   rimstore.removeProduct();
                   break;
                   case 3:
                   rimstore.interateProductList();
                   break;
                   case 4:
                   rimstore.SearchProduct();
                   break;
                   case 5:
                   return;
                }
            }
        }
    }
}
