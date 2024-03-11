using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart
{
    internal class ProductInCart
    {
        public Product Product { get; set; }
        public float Quantity { get; set; }
        public float totalPrice() { return Quantity* Product.Price; }

        public ProductInCart(Product product,float quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public ProductInCart()
        {
            Product = new Product();
            Quantity = 0;
        }
        public override string ToString()
        {
            return String.Format("{0} {1:0.00}X {2:0.00} = {3:0.00}",Product.Name,Quantity,Product.Price,totalPrice());
        }
    }
}
