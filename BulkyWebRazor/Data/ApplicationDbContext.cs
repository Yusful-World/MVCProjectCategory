using System;
using BulkyWebRazor.Model;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebRazor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Hello", DisplayOrder = 2 },
                new Category { Id = 2, Name = "Science", DisplayOrder = 3 },
                new Category { Id = 3, Name = "Technology", DisplayOrder = 4 }
            );
        }
    }
}
