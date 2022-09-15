using BigOn.WebUi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BigOn.WebUi.Models.DataContexts
{
    public class BigOnDbContext : DbContext
    {
        public BigOnDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactPost> ContactPosts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
