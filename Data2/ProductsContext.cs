using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoCrafts.WebSite.Models;

namespace ServiceInjection.Data2
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Product { get; set; }
    }
}
