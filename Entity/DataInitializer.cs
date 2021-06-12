using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BitirmeProjesi.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name="KAMERA",Description="Kamera Ürünleri"},
                new Category() {Name="BİLGİSAYAR",Description="Bilgisayar Ürünleri"}
            };

            foreach (var item in kategoriler)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() {Name="Canon",Description="Kamera",Price=2500,Stock=50,IsHome=true,CategoryId=1,Image="kamera1.jpg",IsApproved=true,IsFeatured=false },
                new Product() {Name="Asus bilgisayar",Description="Asus bilgisayar ürünleri",Price=5000,Stock=10,IsHome=false,CategoryId=2,Image="pc1.jpg",IsApproved=true,IsFeatured=true },
                new Product() {Name="Casper bilgisayar",Description="Casper bilgisayar ürünleri",Price=2000,Stock=150,IsHome=true,CategoryId=2,Image="pc2.jpg",IsApproved=true,IsFeatured=true }
            };

            foreach (var item in urunler)
            {
                context.Products.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}