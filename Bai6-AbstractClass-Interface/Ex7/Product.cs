using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex7
{
    public class Product
    {
        public String Name;
        public String Description;
        public double Price;
        public int[] Rate;
        public void viewInfo()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Description : " + Description);
        }
    }
}