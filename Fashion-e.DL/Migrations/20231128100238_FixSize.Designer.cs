﻿// <auto-generated />
using System;
using Fashion_e.DL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fashion_e.DL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231128100238_FixSize")]
    partial class FixSize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fashion_e.Common.Entities.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDelete")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Fashion_e.Common.Entities.Entities.ColorProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ColorCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDelete")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("ColorProduct");
                });

            modelBuilder.Entity("Fashion_e.Common.Entities.Entities.Gallery", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDelete")
                        .HasColumnType("int");

                    b.Property<int>("IsThumbnail")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PublicId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Gellery");
                });

            modelBuilder.Entity("Fashion_e.Common.Entities.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDelete")
                        .HasColumnType("int");

                    b.Property<string>("Material")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Fashion_e.Common.Entities.Entities.SizeColorProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("ColorProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDelete")
                        .HasColumnType("int");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid>("SizeProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("UnitInOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorProductId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeProductId");

                    b.ToTable("SizeColorProduct");
                });

            modelBuilder.Entity("Fashion_e.Common.Entities.Entities.SizeProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IsDelete")
                        .HasColumnType("int");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("SizeProduct");
                });

            modelBuilder.Entity("Fashion_e.Common.Entities.Entities.Category", b =>
                {
                    b.HasOne("Fashion_e.Common.Entities.Entities.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Fashion_e.Common.Entities.Entities.Gallery", b =>
                {
                    b.HasOne("Fashion_e.Common.Entities.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fashion_e.Common.Entities.Entities.Product", b =>
                {
                    b.HasOne("Fashion_e.Common.Entities.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fashion_e.Common.Entities.Entities.SizeColorProduct", b =>
                {
                    b.HasOne("Fashion_e.Common.Entities.Entities.ColorProduct", null)
                        .WithMany()
                        .HasForeignKey("ColorProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fashion_e.Common.Entities.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fashion_e.Common.Entities.Entities.SizeProduct", null)
                        .WithMany()
                        .HasForeignKey("SizeProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fashion_e.Common.Entities.Entities.Category", b =>
                {
                    b.Navigation("Children");
                });
#pragma warning restore 612, 618
        }
    }
}
