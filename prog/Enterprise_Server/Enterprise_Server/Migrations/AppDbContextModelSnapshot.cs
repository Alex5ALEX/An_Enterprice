﻿// <auto-generated />
using System;
using Enterprise_Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Enterprise_Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Enterprise_Server.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid?>("EnterpriseId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id_Enterprise")
                        .HasColumnType("char(36)");

                    b.Property<string>("Jobtitle")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EnterpriseId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Enterprise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Enterprises");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Material", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("Enterprise_Server.Models.MaterialCompaund", b =>
                {
                    b.Property<Guid>("Id_Material")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id_Product")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("MaterialId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<double>("Weight")
                        .HasColumnType("double");

                    b.HasKey("Id_Material", "Id_Product");

                    b.HasIndex("MaterialId");

                    b.HasIndex("ProductId");

                    b.ToTable("MaterialCompaunds");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("Id_Customer")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Enterprise_Server.Models.OrderCompaund", b =>
                {
                    b.Property<Guid>("Id_Order")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id_Product")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id_Order", "Id_Product");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderCompaunds");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("EnterpriseId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id_Enterprise")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<double>("Weight")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("EnterpriseId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Provider", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Supply", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("Id_Provider")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProviderId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Supplies");
                });

            modelBuilder.Entity("Enterprise_Server.Models.SupplyCompaund", b =>
                {
                    b.Property<Guid>("Id_Supply")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Id_Material")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("MaterialId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProviderId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<Guid?>("SupplyId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id_Supply", "Id_Material");

                    b.HasIndex("MaterialId");

                    b.HasIndex("ProviderId");

                    b.HasIndex("SupplyId");

                    b.ToTable("SupplyCompaunds");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Employee", b =>
                {
                    b.HasOne("Enterprise_Server.Models.Enterprise", "Enterprise")
                        .WithMany("Employees")
                        .HasForeignKey("EnterpriseId");

                    b.Navigation("Enterprise");
                });

            modelBuilder.Entity("Enterprise_Server.Models.MaterialCompaund", b =>
                {
                    b.HasOne("Enterprise_Server.Models.Material", "Material")
                        .WithMany("MaterialCompaunds")
                        .HasForeignKey("MaterialId");

                    b.HasOne("Enterprise_Server.Models.Product", "Product")
                        .WithMany("MaterialCompaunds")
                        .HasForeignKey("ProductId");

                    b.Navigation("Material");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Order", b =>
                {
                    b.HasOne("Enterprise_Server.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Enterprise_Server.Models.OrderCompaund", b =>
                {
                    b.HasOne("Enterprise_Server.Models.Order", "Order")
                        .WithMany("OrderCompaunds")
                        .HasForeignKey("OrderId");

                    b.HasOne("Enterprise_Server.Models.Product", "Product")
                        .WithMany("OrderCompaunds")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Product", b =>
                {
                    b.HasOne("Enterprise_Server.Models.Enterprise", "Enterprise")
                        .WithMany("Products")
                        .HasForeignKey("EnterpriseId");

                    b.Navigation("Enterprise");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Supply", b =>
                {
                    b.HasOne("Enterprise_Server.Models.Provider", "Provider")
                        .WithMany()
                        .HasForeignKey("ProviderId");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("Enterprise_Server.Models.SupplyCompaund", b =>
                {
                    b.HasOne("Enterprise_Server.Models.Material", "Material")
                        .WithMany("SupplyCompaunds")
                        .HasForeignKey("MaterialId");

                    b.HasOne("Enterprise_Server.Models.Provider", null)
                        .WithMany("SupplyCompaunds")
                        .HasForeignKey("ProviderId");

                    b.HasOne("Enterprise_Server.Models.Supply", "Supply")
                        .WithMany("SupplyCompaunds")
                        .HasForeignKey("SupplyId");

                    b.Navigation("Material");

                    b.Navigation("Supply");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Enterprise", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Material", b =>
                {
                    b.Navigation("MaterialCompaunds");

                    b.Navigation("SupplyCompaunds");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Order", b =>
                {
                    b.Navigation("OrderCompaunds");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Product", b =>
                {
                    b.Navigation("MaterialCompaunds");

                    b.Navigation("OrderCompaunds");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Provider", b =>
                {
                    b.Navigation("SupplyCompaunds");
                });

            modelBuilder.Entity("Enterprise_Server.Models.Supply", b =>
                {
                    b.Navigation("SupplyCompaunds");
                });
#pragma warning restore 612, 618
        }
    }
}
