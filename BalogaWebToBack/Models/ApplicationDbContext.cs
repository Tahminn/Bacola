using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BalogaWebToBack.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("DbProducts")
        {
        }
        public DbSet<Product> Products { get; set; }

    }
}
