﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pharmacy_pos.ef.Data;

#nullable disable

namespace pharmacy_pos.ef.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("pharmacy_pos.ef.Entities.CurrentStock.CurrentStock", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("AvailableStock")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("CurrentStock");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.Product.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BarCodeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BarCodePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufactorer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PackCostPrice")
                        .HasColumnType("float");

                    b.Property<int>("PackQuantity")
                        .HasColumnType("int");

                    b.Property<double>("PackRetailPrice")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RackNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.ProductBatch.ProductBatch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BatchNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("BatchStock")
                        .HasColumnType("bigint");

                    b.Property<string>("ExpiryDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductBatch");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.ProductPurchase.ProductPurchase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PurchaseDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SupplierId");

                    b.ToTable("ProductPurchase");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.ProductType.ProductType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.PurchaseItem.PurchaseItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Percentage")
                        .HasColumnType("float");

                    b.Property<string>("ProductBatch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductExpiry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductRetailPrice")
                        .HasColumnType("float");

                    b.Property<double>("ProductTotal")
                        .HasColumnType("float");

                    b.Property<double>("ProductTradePrice")
                        .HasColumnType("float");

                    b.Property<Guid>("PurchaseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PurchaseId");

                    b.ToTable("PurchaseItem");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.SaleHistory.SaleHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("SaleHistory");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.SaleItem.SaleItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<double>("ItemTotal")
                        .HasColumnType("float");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductSalePrice")
                        .HasColumnType("float");

                    b.Property<int>("QuantitySold")
                        .HasColumnType("int");

                    b.Property<Guid>("SaleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleItem");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.Supplier.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.Product.Product", b =>
                {
                    b.HasOne("pharmacy_pos.ef.Entities.ProductType.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.ProductBatch.ProductBatch", b =>
                {
                    b.HasOne("pharmacy_pos.ef.Entities.Product.Product", "Product")
                        .WithMany("Batches")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.ProductPurchase.ProductPurchase", b =>
                {
                    b.HasOne("pharmacy_pos.ef.Entities.Supplier.Supplier", "Supplier")
                        .WithMany("Purchases")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.PurchaseItem.PurchaseItem", b =>
                {
                    b.HasOne("pharmacy_pos.ef.Entities.ProductPurchase.ProductPurchase", "Purchase")
                        .WithMany("PurchaseItems")
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Purchase");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.SaleItem.SaleItem", b =>
                {
                    b.HasOne("pharmacy_pos.ef.Entities.SaleHistory.SaleHistory", "Sale")
                        .WithMany("Sales")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.Product.Product", b =>
                {
                    b.Navigation("Batches");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.ProductPurchase.ProductPurchase", b =>
                {
                    b.Navigation("PurchaseItems");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.ProductType.ProductType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.SaleHistory.SaleHistory", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("pharmacy_pos.ef.Entities.Supplier.Supplier", b =>
                {
                    b.Navigation("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}
