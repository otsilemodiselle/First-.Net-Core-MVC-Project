﻿// <auto-generated />
using Bulky.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bulky.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240825174704_AddCategoryToDbAndSeedTable")]
    partial class AddCategoryToDbAndSeedTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Handcrafted Jewelry"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Locally-Produced Clothing"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Art and Home Decor"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Furniture and Homeware"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Gourmet Food and Snacks"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 6,
                            Name = "Health and Wellness Products"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 7,
                            Name = "Bespoke Accessories"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}