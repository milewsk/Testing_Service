using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Testing_Service.Models;

namespace Testing_Service.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) :base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
