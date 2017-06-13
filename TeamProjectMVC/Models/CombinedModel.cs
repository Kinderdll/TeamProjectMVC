using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamProjectMVC.Models
{
    public class CombinedModel
    {
        public List<User> Users { get; set; }
        public Order Order { get; set; }
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
    }
}