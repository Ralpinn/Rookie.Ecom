using Microsoft.EntityFrameworkCore;
using Rookie.Ecom.DataAccessor.Entities;

namespace Rookie.Ecom.DataAccessor.Data
{
    public class EcomDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<ProductRating> ProductRatings { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

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

            builder.Entity<Publisher>(entity =>
            {
                entity.ToTable(name: "Publisher");
            });

            builder.Entity<ProductRating>(entity =>
            {
                entity.ToTable(name: "ProductRating");
            });

            builder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable(name: "OrderDetail");
            });
            builder.Entity<CustomerAddress>(entity =>
            {
                entity.ToTable(name: "CustomerAddress");
            });

            builder.Entity<Customer>(entity =>
            {
                entity.ToTable(name: "Customer");
            });

            builder.Entity<Order>(entity =>
            {
                entity.ToTable(name: "Order");
            });

            builder.Entity<Role>(entity =>
            {
                entity.ToTable(name: "Role");
            });

            builder.Entity<User>(entity =>
            {
                entity.ToTable(name: "User");
            });
        }
    }
}
