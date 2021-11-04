using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopProject.Models
{
    [Table("Category")]
    public class Category
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        [StringLength(100)]
        public string CategoryName { get; set; }
        //Bir kategorinin birden fazla ürünü olcaktır.
        public virtual List<Product> CategoryProduct { get; set; }
        
    }
}