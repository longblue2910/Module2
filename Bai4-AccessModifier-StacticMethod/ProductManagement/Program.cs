using System;

namespace ProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateProduct();
            ProductService.Show();
            RemoveProduct();
            ProductService.Show();
        }
        public static void CreateProduct()
        {
            Random rnd = new Random();
            var product = new Product()
            {
                Code = rnd.Next(1000,9999).ToString(),
                Date = DateTime.Parse("2020/07/07"),
                Manufactory = "USA",
                Name = "IP6",
                Price = 5000000
            };
            Product.Service.Add(Product);
        }
        public static void RemoveProduct()
        {
            Console.Write("Enter Code :");
            var code = Console.ReadLine();
            Product.Service.Delete(code);
        }
    }
}
