using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartAsp.Models;

namespace SmartAsp.Data
{
    public class SmartAspContext : DbContext
    {
        public SmartAspContext (DbContextOptions<SmartAspContext> options)
            : base(options)
        {
        }

        public DbSet<SmartAsp.Models.Department> Department { get; set; }
        public DbSet<SmartAsp.Models.Brand> Brand { get; set; }
        public DbSet<SmartAsp.Models.Product> Product { get; set; }
    }
}
