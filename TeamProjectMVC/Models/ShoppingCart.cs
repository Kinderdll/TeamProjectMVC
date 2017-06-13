using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamProjectMVC.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public User User { get; set; }
        
        public ShoppingCart()
        {
            Products = new List<Product>();
        }
    }
}