using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamProjectMVC.Models
{
    public class SearchViewModel
    {
        public string Search { get; set; }
        public List<Product> Results { get; set; }

        public SearchViewModel() //constructor
        {
            Results = new List<Product>();
        }
    }
}