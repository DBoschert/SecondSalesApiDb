using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SecondSalesApiDb.Models;

namespace SecondSalesApiDb.Data
{
    public class SecondSalesDbContext : DbContext
    {
        public SecondSalesDbContext (DbContextOptions<SecondSalesDbContext> options)
            : base(options)
        {
        }

        public DbSet<SecondSalesApiDb.Models.Customer> Customers { get; set; } = default!;

        public DbSet<SecondSalesApiDb.Models.Order> Orders { get; set; } = default!;

        public DbSet<SecondSalesApiDb.Models.Item> Items { get; set; } = default!;

        public DbSet<SecondSalesApiDb.Models.OrderLine> OrderLines { get; set; } = default!;

        public DbSet<SecondSalesApiDb.Models.Employee> Employees { get; set; } = default!;
    }
}
