using ShopProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopProject.ViewModels
{
    public class ViewsModel
    {
        public IEnumerable<Product> Product { get; set; }
        public IEnumerable<Category> Category { get;set; }
    }
}