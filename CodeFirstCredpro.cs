using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;


namespace CodeFirstCredpro
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerDbContext context = new CustomerDbContext();
            var orders = context.Orders;

            var order1 = orders.Add(new Order()
            {
                OrderID = 1,
                OrderDate = new DateTime(2020, 01, 01),
                CustomerID = 1,
                ShippedDate = new DateTime(2020, 01, 15)

            });
            var order2 = orders.Add(new Order()
            {
                OrderID = 2,
                OrderDate = new DateTime(2020, 01, 10),
                CustomerID = 2,
                ShippedDate = new DateTime(2020, 01, 15)

            });
            context.SaveChanges();
        }
    }
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(): base("name=CustomerDbContext")
        { }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string country { get; set; }
    }
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public DateTime ShippedDate { get; set; }
    }
}
