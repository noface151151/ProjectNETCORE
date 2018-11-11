﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ShopOnline.Data.Models;

namespace ShopOnline.Migrations
{
    [DbContext(typeof(OnlineShopDBContext))]
    [Migration("20181110164041_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopOnline.Models.MainGroup", b =>
                {
                    b.Property<int>("MainGroupId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MainGroupName");

                    b.HasKey("MainGroupId");

                    b.ToTable("MainGroups");
                });

            modelBuilder.Entity("ShopOnline.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desciption");

                    b.Property<int?>("MainGroupId");

                    b.Property<string>("ProductName");

                    b.HasKey("ProductId");

                    b.HasIndex("MainGroupId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ShopOnline.Models.ProductImage", b =>
                {
                    b.Property<int>("ProductImageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageLink");

                    b.Property<int?>("ProductId");

                    b.HasKey("ProductImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("ShopOnline.Models.Product", b =>
                {
                    b.HasOne("ShopOnline.Models.MainGroup", "MainGroup")
                        .WithMany("Products")
                        .HasForeignKey("MainGroupId");
                });

            modelBuilder.Entity("ShopOnline.Models.ProductImage", b =>
                {
                    b.HasOne("ShopOnline.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
