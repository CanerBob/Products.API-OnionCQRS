﻿// <auto-generated />
using System;
using API.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240223114505_Mig1")]
    partial class Mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(5536),
                            IsDeleted = false,
                            Name = "Marka1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(5537),
                            IsDeleted = false,
                            Name = "Marka2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(5539),
                            IsDeleted = true,
                            Name = "Marka3"
                        });
                });

            modelBuilder.Entity("API.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priorty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(6985),
                            IsDeleted = false,
                            Name = "Elektronik",
                            ParentId = 0,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(6986),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priorty = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(7028),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priorty = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(7029),
                            IsDeleted = false,
                            Name = "Kadın",
                            ParentId = 2,
                            Priorty = 1
                        });
                });

            modelBuilder.Entity("API.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(8439),
                            Description = "Açıklama falan filan",
                            IsDeleted = false,
                            Title = "Lorem falan filan"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(8441),
                            Description = "Açıklama falan filan",
                            IsDeleted = true,
                            Title = "Lorem falan filan"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(8442),
                            Description = "Açıklama falan filan",
                            IsDeleted = false,
                            Title = "Lorem falan filan"
                        });
                });

            modelBuilder.Entity("API.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(9544),
                            Description = "Ürün AÇıklaması falan filan",
                            Discount = 5m,
                            IsDeleted = false,
                            Price = 1000m,
                            Title = "Ürün Başlığı falan filan"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedDate = new DateTime(2024, 2, 23, 14, 45, 5, 423, DateTimeKind.Local).AddTicks(9547),
                            Description = "Ürün AÇıklaması falan filan",
                            Discount = 5m,
                            IsDeleted = false,
                            Price = 1000m,
                            Title = "Ürün Başlığı falan filan"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("API.Domain.Entities.Detail", b =>
                {
                    b.HasOne("API.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("API.Domain.Entities.Product", b =>
                {
                    b.HasOne("API.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("API.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
