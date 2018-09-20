using System;
using System.Collections.Generic;
using System.Text;
using App.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace App.DataAccess.Concrete.EntityFramework
{
    public class AppContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
