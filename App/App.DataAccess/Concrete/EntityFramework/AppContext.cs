using System;
using System.Collections.Generic;
using System.Text;
using App.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace App.DataAccess.Concrete.EntityFramework
{
    public class AppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AppDb;Integrated Security=True");
        }
       
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
