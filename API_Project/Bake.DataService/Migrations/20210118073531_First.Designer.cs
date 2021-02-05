﻿// <auto-generated />
using System;
using Bake.DataService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Bake.DataService.Migrations
{
    [DbContext(typeof(BakeDbContext))]
    [Migration("20210118073531_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Bake.DataService.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<int>("Phone")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Bake.DataService.Models.Orders", b =>
                {
                    b.Property<int>("OrdersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("customerID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("OrdersID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Bake.DataService.Models.RDishes", b =>
                {
                    b.Property<int>("RDishesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("calories")
                        .HasColumnType("integer");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.Property<string>("tName")
                        .HasColumnType("text");

                    b.Property<bool>("type")
                        .HasColumnType("boolean");

                    b.Property<int>("weight")
                        .HasColumnType("integer");

                    b.HasKey("RDishesID");

                    b.ToTable("RDishes");
                });

            modelBuilder.Entity("Bake.DataService.Models.SDishes", b =>
                {
                    b.Property<int>("SDishesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("calories")
                        .HasColumnType("integer");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.Property<string>("tName")
                        .HasColumnType("text");

                    b.Property<bool>("type")
                        .HasColumnType("boolean");

                    b.Property<int>("weight")
                        .HasColumnType("integer");

                    b.HasKey("SDishesID");

                    b.ToTable("SDishes");
                });
#pragma warning restore 612, 618
        }
    }
}