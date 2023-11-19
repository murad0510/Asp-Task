using Asp_Task.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Asp_Task.Data
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext>
            optionContext)
        : base(optionContext)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
