using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShopProject.Models
{
    [Table("User")]
    public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
         [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(20), Required]
        public string Password { get; set; }
        public virtual ICollection<UserProduct> UserProducts { get; set; }


    }
}