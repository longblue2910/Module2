using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex7
{
    class Shop
    {
        Product[] ProductList = new Product[0];
        public void addProduct (Product p)
        {
            Console.WriteLine("Name : ");
            p.Name = Console.ReadLine();
            
            do
            {
                p.Price = double.Parse(Console.ReadLine());
            } while (! (p.Price > 0 && p.Price <= 100 )); 
            Console.WriteLine("Description : ");
            p.Description = Console.ReadLine();

            Console.WriteLine("Number of rates : ");
            int T = int.Parse(Console.ReadLine());
            p.Rate = new int [T];
            for (int i = 0; i < T; i++)
            {
                do
                {
                    Console.WriteLine("Rate " +(i + 1) + ": ");
                    p.Rate[i] = int.Parse(Console.ReadLine());
                } while (!(p.Rate[i] > 1 && p.Rate[i] <= 5 ));
            }
        }
        public void SearchProduct()
        {
            double minPrice;
            double maxPrice;
            bool search = false;

            do
            {
                Console.WriteLine("Please enter Min Price :");
                minPrice = double.Parse(Console.ReadLine());

            } while (! (minPrice > 0 && minPrice <= 100));
            do
            {
                Console.WriteLine("Please enter Min price : ");
                maxPrice = double.Parse(Console.ReadLine());
            } while (!(minPrice <= 100 && maxPrice > minPrice));
           
            foreach (Product p in ProductList)
            {
                if (p.Price >= minPrice && p.Price <= maxPrice)
                {
                    search = true;
                    p.viewInfo();
                }
                if (search == false)
                {
                    Console.WriteLine("Not found :");
                }
            }
        }
        public void removeProduct()
        {
            bool search = false;
            Console.WriteLine("Enter the name of the product you want to delete : ");
            String name = Console.ReadLine();
            foreach (Product p in ProductList)
            {
                if (name.Equals(p.Name))
                {
                    search = true;
                    break;
                }
                if (search == true)
                {
                    Console.WriteLine("Remove Sucessful !");
                }
                else Console.WriteLine("Not Found !");
            }
        }
        public void interateProductList()
        {
            foreach (Product p in ProductList)
            {
                p.viewInfo(); 
                float averateRate = 0;
                foreach (int rate in p.Rate)
                {
                    averateRate += rate;
                }
                Console.WriteLine("Averate Rate :" + averateRate/p.Rate.Length);
            }
        }
    }
}