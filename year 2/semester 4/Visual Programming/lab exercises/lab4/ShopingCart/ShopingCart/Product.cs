using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }

        public Product(string name, string category, float price)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public Product()
        {
            Name = Category = "";
            Price = 0;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
