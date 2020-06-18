using Microsoft.EntityFrameworkCore;
using ProductCSAPI;

namespace ProductCSAPI.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Products> ProductsItems { get; set; }
    }
}