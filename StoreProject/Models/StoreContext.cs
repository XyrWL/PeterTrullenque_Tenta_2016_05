using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoreProject.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

        public StoreContext() : base("StoreDB")
        {
            Database.SetInitializer(new StoreInitializer());
        }
    }

    public class StoreInitializer : DropCreateDatabaseAlways<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var stores = new List<Store>
            {
                new Store
                {
                    Name = "FirstStore",
                    Address = "First street, 1",
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Apple",
                            ProductText = "These are some nice apples.",
                            ProductNumber = "p-55",
                            ProductsInStock = 10,
                            Price = 5.5
                        },
                        new Product
                        {
                            Name = "Orange",
                            ProductText = "These are some decent oranges.",
                            ProductNumber = "p-120",
                            ProductsInStock = 12,
                            Price = 4.9
                        }
                    }
                },
                new Store
                {
                    Name = "SecondStore",
                    Address = "Second street, 2",
                    Products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Wine",
                            ProductText = "This is a pretty good wine.",
                            ProductNumber = "p-200",
                            ProductsInStock = 20,
                            Price = 199.9
                        },
                        new Product
                        {
                            Name = "Beer",
                            ProductText = "This is an acceptable beer.",
                            ProductNumber = "p-259",
                            ProductsInStock = 250,
                            Price = 9.9
                        }
                    }
                }
            };
            context.Stores.AddRange(stores);
            context.SaveChanges();
        }
    }
}