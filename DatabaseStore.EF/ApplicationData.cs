using DatabaseStore.Model;
using System.Data.Entity;

namespace DatabaseStore.EF
{
    public class ApplicationData : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderList> OrderList { get; set; }
    }
}
