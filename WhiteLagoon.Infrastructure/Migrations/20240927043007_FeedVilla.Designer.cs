﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WhiteLagoon.Infrastructure.Data;

#nullable disable

namespace WhiteLagoon.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240927043007_FeedVilla")]
    partial class FeedVilla
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WhiteLagoon.Domain.Entity.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7396),
                            Description = "A beautiful villa with an ocean view.",
                            ImageUrl = "https://example.com/images/villa1.jpg",
                            Name = "Ocean View Villa",
                            Occupancy = 4,
                            Price = 300.0,
                            Sqft = 1500,
                            UpdatedDate = new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7410)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7412),
                            Description = "A cozy villa in the mountains.",
                            ImageUrl = "https://example.com/images/villa2.jpg",
                            Name = "Mountain Retreat",
                            Occupancy = 3,
                            Price = 200.0,
                            Sqft = 1200,
                            UpdatedDate = new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7413)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7415),
                            Description = "An elegant penthouse in the city center.",
                            ImageUrl = "https://example.com/images/villa3.jpg",
                            Name = "Luxury Penthouse",
                            Occupancy = 5,
                            Price = 500.0,
                            Sqft = 2000,
                            UpdatedDate = new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7416)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7418),
                            Description = "A quaint cottage in the countryside.",
                            ImageUrl = "https://example.com/images/villa4.jpg",
                            Name = "Countryside Cottage",
                            Occupancy = 2,
                            Price = 150.0,
                            Sqft = 1000,
                            UpdatedDate = new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7419)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
