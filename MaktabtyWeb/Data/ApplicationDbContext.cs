using MaktabtyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace MaktabtyWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Science" },
                new Category { Id = 2, Name = "Scifi" },
                new Category { Id = 3, Name = "History" }
            );


        }
    }
}
