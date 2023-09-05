﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlatformDemoLib.Data;

#nullable disable

namespace PlatformDemoApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230905123820_CustomerSeeder")]
    partial class CustomerSeeder
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlatformDemoLib.Models.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ContactNo = "6543210",
                            Name = "Michael Curry"
                        },
                        new
                        {
                            Id = 2L,
                            ContactNo = "0654321",
                            Name = "Stephen Jordan"
                        },
                        new
                        {
                            Id = 3L,
                            ContactNo = "1065432",
                            Name = "Kobe Durant"
                        },
                        new
                        {
                            Id = 4L,
                            ContactNo = "2106543",
                            Name = "Kevin Bryant"
                        },
                        new
                        {
                            Id = 5L,
                            ContactNo = "3210654",
                            Name = "Derrick Nowitzki"
                        },
                        new
                        {
                            Id = 6L,
                            ContactNo = "4321065",
                            Name = "Dirk Rose"
                        },
                        new
                        {
                            Id = 7L,
                            ContactNo = "5432106",
                            Name = "Jordan Green"
                        },
                        new
                        {
                            Id = 8L,
                            ContactNo = "1234560",
                            Name = "Jeff Clarkson"
                        },
                        new
                        {
                            Id = 9L,
                            ContactNo = "234501",
                            Name = "Ben Tatum"
                        },
                        new
                        {
                            Id = 10L,
                            ContactNo = "345012",
                            Name = "Jason Simmons"
                        },
                        new
                        {
                            Id = 11L,
                            ContactNo = "450123",
                            Name = "Luka Kidd"
                        },
                        new
                        {
                            Id = 12L,
                            ContactNo = "501234",
                            Name = "Jason Doncic"
                        },
                        new
                        {
                            Id = 13L,
                            ContactNo = "01235",
                            Name = "Kyrie George"
                        });
                });

            modelBuilder.Entity("PlatformDemoLib.Models.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<string>("OrderNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("PlatformDemoLib.Models.Order", b =>
                {
                    b.HasOne("PlatformDemoLib.Models.Customer", "customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });

            modelBuilder.Entity("PlatformDemoLib.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
