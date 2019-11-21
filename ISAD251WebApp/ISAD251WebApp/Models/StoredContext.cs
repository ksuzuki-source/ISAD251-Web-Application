using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace ISAD251WebApp.Models
{
    public class StoredContext: DbContext
    {
        public StoredContext()
        {
        }

        public StoredContext(DbContextOptions<StoredContext> options)
        : base(options)
        { }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
