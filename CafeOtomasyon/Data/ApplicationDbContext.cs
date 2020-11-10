using CafeOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyon.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TableNumber> TableNumbers { get; set; }
    }
}
