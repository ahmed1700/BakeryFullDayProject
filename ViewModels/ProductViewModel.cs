using BakeryShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAPP.ViewModels
{
    public class ProductViewModel
    {
        public Product FeaturedProduct { get; set; }
        public List<Product> Products { get; set; }
    }
}
