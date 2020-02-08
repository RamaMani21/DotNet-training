using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;


namespace newcodefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDBContext context = new OrderDBContext();
            var order = context.Orders;

            var Order1 = order.Add(new Order() { OrderID = 1, ShipName = "zoe", ShipCity = "bern", CustomerID = 1 });
            var Order2 = order.Add(new Order() { OrderID = 2, ShipName = "veer",  ShipCity = "italy", CustomerID = 1 });
            var Order3 = order.Add(new Order() { OrderID = 3, ShipName = "pat",  ShipCity = "zurich", CustomerID = 1 });

            
            context.SaveChanges();


        }
        public class OrderDBContext : DbContext
        {
            public OrderDBContext() :
                 base("name=OrderDBContext")
            { }

            public DbSet<Order> Orders { get; set; }
            
        }

        public class Order
        {
            public int OrderID { get; set; }
            public string ShipName { get; set; }
            public string ShipCity { get; set; }
            public int CustomerID { get; set; }
        }

       
    }


}
