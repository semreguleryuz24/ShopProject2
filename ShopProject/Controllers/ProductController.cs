using ShopProject.Models;
using ShopProject.Models.Managers;
using ShopProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            DatabaseContext db = new DatabaseContext();
         List<User> users = db.User.ToList();

            var usr = new User();
            usr.UserName = "dsadadad";
            usr.Password = "123";

            db.User.Add(usr);
            db.SaveChanges();

            return View(users);
        }
   
        
        public ActionResult NewProduct(UserProduct prdct)
        {
            DatabaseContext db = new DatabaseContext();
            db.UserProduct.Add(prdct);

           //int result = db.SaveChanges();
            //if(result>0)
            //{
            //    ViewBag.Result = "Ürün kaydedilmiştir.";
            //    ViewBag.Status = "success";

            //}
            //else
            //{
            //    ViewBag.Result = "Ürün kaydedilmemiştir.";
            //    ViewBag.Status = "danger";
            //}

            return View();
        }
        
    }
}