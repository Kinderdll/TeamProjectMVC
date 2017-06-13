using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TeamProjectMVC.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
       public string ImgPath { get; set; }

        //List<Product> list = new List<Product>()
        //{
        //    new Product(){Price=50, Description="ASasd", ProductID=1, ProductName="P1"},
        //    new Product(){Price=51, Description="ASasd", ProductID=2, ProductName="P2"},
        //    new Product(){Price=52, Description="ASasd", ProductID=3, ProductName="P3"},
        //    new Product(){Price=53, Description="ASasd", ProductID=4, ProductName="P4"}
        //};
    }
    
}