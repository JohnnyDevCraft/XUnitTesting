using System;
using Microsoft.EntityFrameworkCore;
using TestingTesting.Domain;
namespace TestingTesting.Data
{
    public class AppContext : DbContext
    {
        public AppContext()
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> Details { get; set; }
    }
}
