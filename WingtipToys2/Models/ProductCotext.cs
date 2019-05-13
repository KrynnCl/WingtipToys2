using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WingtipToys2.Models
{
    public class ProductCotext: DbContext
    {
        public ProductCotext() : base("Wingtiptoys2") { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }

    }
}