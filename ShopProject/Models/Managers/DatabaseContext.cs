using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ShopProject.Models.Managers
{
    public class DatabaseContext :DbContext
    { 
        public DbSet<User>User { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<UserProduct> UserProduct { get; set; }
       
        public DatabaseContext()
        {
            
            Database.SetInitializer(new DatabaseCreater());
        }

    }
    public class DatabaseCreater : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            //10 tane kişiler insert ediliyor.
            for(int i=0;i<10;i++)
            {
                User user = new User();               
                user.UserName = FakeData.NameData.GetFullName();               
              
            }
            context.SaveChanges();

            List<User> allUser = context.User.ToList();//select * from
            //Ürünler insert ediliyor.
            foreach(User kisi in allUser)
            {
                for(int i=0;i<FakeData.NumberData.GetNumber(1,5);i++)
                {
                    Product prdct = new Product();
                    prdct.Price = FakeData.NumberData.GetNumber(100, 200);
                    prdct.ProductName = FakeData.NameData.GetCompanyName();
                    prdct.StockAccount= FakeData.NumberData.GetNumber(100, 200);
                    //prdct.UserProducts=kisi;
                    

                    context.Product.Add(prdct);
                }
            }
            context.SaveChanges();
        }
    }
}