using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment_1___COMP2139.Migrations
{
    /// <inheritdoc />
    public partial class AddConcertsAndSports : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Live music performances", "Concerts" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sporting events and games", "Sports" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableTickets", "Date", "TicketPrice", "Title" },
                values: new object[] { 500, new DateTime(2025, 10, 20, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2605), 150.00m, "Taylor Swift: The Eras Tour" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableTickets", "CategoryId", "Date", "TicketPrice", "Title" },
                values: new object[] { 400, 1, new DateTime(2025, 10, 30, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2611), 120.00m, "Coldplay: Music of the Spheres" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "AvailableTickets", "CategoryId", "Date", "TicketPrice", "Title" },
                values: new object[,]
                {
                    { 3, 300, 1, new DateTime(2025, 11, 9, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2612), 110.00m, "Billie Eilish Live" },
                    { 4, 350, 1, new DateTime(2025, 11, 19, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2614), 100.00m, "Bruno Mars Night" },
                    { 5, 250, 1, new DateTime(2025, 11, 29, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2615), 200.00m, "Adele: One Night Only" },
                    { 6, 450, 1, new DateTime(2025, 12, 9, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2616), 130.00m, "Ed Sheeran: Mathematics Tour" },
                    { 7, 1000, 2, new DateTime(2025, 10, 25, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2618), 90.00m, "NBA Finals Game 1" },
                    { 8, 2000, 2, new DateTime(2025, 11, 4, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2619), 250.00m, "Super Bowl LVIII" },
                    { 9, 1500, 2, new DateTime(2025, 11, 14, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2620), 75.00m, "World Cup Qualifier" },
                    { 10, 1200, 2, new DateTime(2025, 11, 24, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2621), 95.00m, "Stanley Cup Final" },
                    { 11, 500, 2, new DateTime(2025, 12, 4, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2623), 180.00m, "Wimbledon Finals" },
                    { 12, 800, 2, new DateTime(2025, 12, 14, 16, 33, 57, 784, DateTimeKind.Utc).AddTicks(2624), 160.00m, "Olympic Track Finals" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Live music events", "Music" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Technology conferences", "Tech" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableTickets", "Date", "TicketPrice", "Title" },
                values: new object[] { 100, new DateTime(2025, 10, 19, 21, 10, 33, 964, DateTimeKind.Utc).AddTicks(1222), 25.00m, "Jazz Night" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableTickets", "CategoryId", "Date", "TicketPrice", "Title" },
                values: new object[] { 50, 2, new DateTime(2025, 10, 29, 21, 10, 33, 964, DateTimeKind.Utc).AddTicks(1229), 99.00m, "AI Summit" });
        }
    }
}
