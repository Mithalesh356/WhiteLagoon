using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entity;

namespace WhiteLagoon.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Villa> Villas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Ocean View Villa",
                    Description = "A beautiful villa with an ocean view.",
                    Price = 300.00,
                    Sqft = 1500,
                    Occupancy = 4,
                    ImageUrl = "https://example.com/images/villa1.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Name = "Mountain Retreat",
                    Description = "A cozy villa in the mountains.",
                    Price = 200.00,
                    Sqft = 1200,
                    Occupancy = 3,
                    ImageUrl = "https://example.com/images/villa2.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 3,
                    Name = "Luxury Penthouse",
                    Description = "An elegant penthouse in the city center.",
                    Price = 500.00,
                    Sqft = 2000,
                    Occupancy = 5,
                    ImageUrl = "https://example.com/images/villa3.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 4,
                    Name = "Countryside Cottage",
                    Description = "A quaint cottage in the countryside.",
                    Price = 150.00,
                    Sqft = 1000,
                    Occupancy = 2,
                    ImageUrl = "https://example.com/images/villa4.jpg",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }
            );
        }
    }
}
