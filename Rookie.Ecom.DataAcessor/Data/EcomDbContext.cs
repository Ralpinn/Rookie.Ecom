using Microsoft.EntityFrameworkCore;
using Rookie.Ecom.DataAccessor.Entities;
using Rookie.Ecom.DataAcessor.Entities;

namespace Rookie.Ecom.DataAccessor.Data
{
    public class EcomDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Pushlisher> Pushlishers { get; set; }
        public EcomDbContext(DbContextOptions<EcomDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>(entity =>
            {
                entity.ToTable(name: "Category");
            });

            builder.Entity<Product>(entity =>
            {
                entity.ToTable(name: "Product");
            });

            builder.Entity<Author>(entity =>
            {
                entity.ToTable(name: "Author");
            });

            builder.Entity<Pushlisher>(entity =>
            {
                entity.ToTable(name: "Pushlisher");
            });

        }
    }
}
