using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FeedVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7396), "A beautiful villa with an ocean view.", "https://example.com/images/villa1.jpg", "Ocean View Villa", 4, 300.0, 1500, new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7410) },
                    { 2, new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7412), "A cozy villa in the mountains.", "https://example.com/images/villa2.jpg", "Mountain Retreat", 3, 200.0, 1200, new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7413) },
                    { 3, new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7415), "An elegant penthouse in the city center.", "https://example.com/images/villa3.jpg", "Luxury Penthouse", 5, 500.0, 2000, new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7416) },
                    { 4, new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7418), "A quaint cottage in the countryside.", "https://example.com/images/villa4.jpg", "Countryside Cottage", 2, 150.0, 1000, new DateTime(2024, 9, 27, 10, 0, 6, 839, DateTimeKind.Local).AddTicks(7419) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
