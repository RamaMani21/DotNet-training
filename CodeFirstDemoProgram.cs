using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace codefirstdemoprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductDBContext context = new ProductDBContext();
            var product = context.Products;

            var product1 = product.Add(new Product() { ProductID = 1, Name = "coffee drink", Price = 67, Quantity = "250ml", CategoryID = 1 });
            var product2 = product.Add(new Product() { ProductID = 2, Name = "badam drink", Price = 67, Quantity = "250ml", CategoryID = 1 });
            var product3 = product.Add(new Product() { ProductID = 3, Name = "coke drink", Price = 67, Quantity = "250ml", CategoryID = 1 });

            var categories = context.Categories;

            var category1 = categories.Add(new Category() { CategoryID = 1, Name = "Beverages" });

            context.SaveChanges();


        }
    }

    public class ProductDBContext : DbContext
    {
        public ProductDBContext() :
             base("name=ProductDBContext")
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get;  set; }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Quantity { get; set; }
        public int CategoryID { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
