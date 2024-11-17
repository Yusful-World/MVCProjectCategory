using System;
using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Fortune of Time",
                    Author = "Billy Spark",
                    Description = "History; Professor Margaret Hensley stumbles upon an ancient artifact that can manipulate time itself. " +
                    "\r\n\r\nAs she navigates the temptation to rewrite her past, she becomes entangled in a centuries-old \r\n\r\nconflict between secret societies fighting to control the device.",
                    ISBN = "SWD9999001",
                    BookPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80
                },
                new Product
                {
                    Id = 2,
                    Title = "Dark Skies",
                    Author = "Nancy Hoover",
                    Description = "Dark Skies weaves a tale of suspense, betrayal, and redemption as \r\n\r\njournalist Callie Mason races " +
                    "against time to uncover the truth about a decades-old conspiracy \r\n\r\nthreatening her community—one that could forever " +
                    "darken the skies of their future.",
                    ISBN = "CAW777777701",
                    BookPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20
                },
                new Product
                {
                    Id = 3,
                    Title = "Vanish in the Sunset",
                    Author = "Julian Button",
                    Description = "Vanish in the Sunset follows the mysterious disappearance of a legendary outlaw, Cole McRae. " +
                    "\r\nWhen bounty hunter Evelyn Wyatt begins her search, she uncovers more than she bargained \r\nfor—a buried truth " +
                    "about McRae’s intentions and her own family’s involvement.",
                    ISBN = "RITO5555501",
                    BookPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35
                },
                new Product
                {
                    Id = 4,
                    Title = "Cotton Candy",
                    Author = "Abby Muscles",
                    Description = "Cotton Candy is a heartwarming romance set in a bustling amusement park. When two strangers, " +
                    "\r\n\r\nOlivia, a jaded event planner, and Ethan, a struggling artist, meet over a shared cotton candy mishap, " +
                    "\r\n\r\nthey discover the sweet surprises life has in store.",
                    ISBN = "WS3333333301",
                    BookPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55
                },
                new Product
                {
                    Id = 5,
                    Title = "Rock in the Ocean",
                    Author = "Ron Parker",
                    Description = "Rock in the Ocean is a gripping survival drama about marine biologist Lucy Warren, " +
                    "\r\nwho becomes stranded on a desolate island after her research vessel capsizes.",
                    ISBN = "SOTJ1111111101",
                    BookPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20
                },
                new Product
                {
                    Id = 6,
                    Title = "Leaves and Wonders",
                    Author = "Laura Phantom",
                    Description = "A renowned botanist Emma Cline retreats to an enchanting forest to recover from a personal tragedy. " +
                    "\r\nAmong the towering trees and whispering leaves, she stumbles upon a hidden world teeming with magical creatures.",
                    ISBN = "FOT000000001",
                    BookPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20
                }
            );

        }
    }
}
