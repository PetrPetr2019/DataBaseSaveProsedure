using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ComputerCompany
{
    class AppProduct:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<PC> Pcs { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Printer> Printers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ComputerDB;Trusted_Connection=True");
        }
    }
    
}
