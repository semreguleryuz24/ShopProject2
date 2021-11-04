using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopProject.Models
{
    [Table("Product")]
    public class Product
    {
        [Key ,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
       [StringLength(100)]
        public string ProductName { get; set; }       
        public int Price { get; set; }        
        public int StockAccount { get; set; }
        public string Barcode { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<UserProduct> UserProducts { get; set; }

    } 
}