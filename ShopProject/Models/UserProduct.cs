using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopProject.Models
{
    public class UserProduct
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        //public int CategoryID { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }
    }
}
