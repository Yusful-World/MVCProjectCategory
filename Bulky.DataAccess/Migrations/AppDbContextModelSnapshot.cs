﻿// <auto-generated />
using Bulky.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bulky.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BookPrice")
                        .HasColumnType("float");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Billy Spark",
                            BookPrice = 99.0,
                            CategoryId = 1,
                            Description = "History; Professor Margaret Hensley stumbles upon an ancient artifact that can manipulate time itself. \r\n\r\nAs she navigates the temptation to rewrite her past, she becomes entangled in a centuries-old \r\n\r\nconflict between secret societies fighting to control the device.",
                            ISBN = "SWD9999001",
                            ImageUrl = "",
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            Title = "Fortune of Time"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Nancy Hoover",
                            BookPrice = 40.0,
                            CategoryId = 2,
                            Description = "Dark Skies weaves a tale of suspense, betrayal, and redemption as \r\n\r\njournalist Callie Mason races against time to uncover the truth about a decades-old conspiracy \r\n\r\nthreatening her community—one that could forever darken the skies of their future.",
                            ISBN = "CAW777777701",
                            ImageUrl = "",
                            Price = 30.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Dark Skies"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Julian Button",
                            BookPrice = 55.0,
                            CategoryId = 1,
                            Description = "Vanish in the Sunset follows the mysterious disappearance of a legendary outlaw, Cole McRae. \r\nWhen bounty hunter Evelyn Wyatt begins her search, she uncovers more than she bargained \r\nfor—a buried truth about McRae’s intentions and her own family’s involvement.",
                            ISBN = "RITO5555501",
                            ImageUrl = "",
                            Price = 50.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            Title = "Vanish in the Sunset"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Abby Muscles",
                            BookPrice = 70.0,
                            CategoryId = 3,
                            Description = "Cotton Candy is a heartwarming romance set in a bustling amusement park. When two strangers, \r\n\r\nOlivia, a jaded event planner, and Ethan, a struggling artist, meet over a shared cotton candy mishap, \r\n\r\nthey discover the sweet surprises life has in store.",
                            ISBN = "WS3333333301",
                            ImageUrl = "",
                            Price = 65.0,
                            Price100 = 55.0,
                            Price50 = 60.0,
                            Title = "Cotton Candy"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Ron Parker",
                            BookPrice = 30.0,
                            CategoryId = 2,
                            Description = "Rock in the Ocean is a gripping survival drama about marine biologist Lucy Warren, \r\nwho becomes stranded on a desolate island after her research vessel capsizes.",
                            ISBN = "SOTJ1111111101",
                            ImageUrl = "",
                            Price = 27.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            Title = "Rock in the Ocean"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Laura Phantom",
                            BookPrice = 25.0,
                            CategoryId = 3,
                            Description = "A renowned botanist Emma Cline retreats to an enchanting forest to recover from a personal tragedy. \r\nAmong the towering trees and whispering leaves, she stumbles upon a hidden world teeming with magical creatures.",
                            ISBN = "FOT000000001",
                            ImageUrl = "",
                            Price = 23.0,
                            Price100 = 20.0,
                            Price50 = 22.0,
                            Title = "Leaves and Wonders"
                        });
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.HasOne("Bulky.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
