using Microsoft.EntityFrameworkCore;
using SmartCart_MVC_Project.Models.Entities;

namespace SmartCart_MVC_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets (Tables)
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // // Category → Products (One-to-Many)
            // modelBuilder.Entity<Category>()
            //     .HasMany(c => c.Products)
            //     .WithOne(p => p.Category)
            //     .HasForeignKey(p => p.CategoryId);

            // Seed Initial Categories (Optional)
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Electronics" },
                new Category { CategoryId = 2, CategoryName = "Fashion" }
            );
        }
    }
}
