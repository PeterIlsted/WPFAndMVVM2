using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAndMVVM2_opg6.Models
{
    internal class ProductRepo
    {
        public List<Product> Products = new List<Product>() 
        {  
            new Product() {Name = "Apple", Price = 7.95},
            new Product() {Name = "Orange", Price = 5.50},
            new Product() {Name = "Banana", Price = 8.25}
        };
        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}
