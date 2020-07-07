using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement
{
    class Product
    {
        public string Name {get; set;}
        public string Code {get; set;}
        public string Price {get; set;}
        public string Date {get; set;}
        public string Manufactory {get; set;}

        public string GetShowProductInfo()
        {
            return $"{Name}\t{Code}\t{Price}\t{Date.ToString("ddd, MMM dd yyyy")}\t\t{Manufactory}";
        }
    }
}
