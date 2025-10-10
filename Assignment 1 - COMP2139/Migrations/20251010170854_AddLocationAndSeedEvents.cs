using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment_1___COMP2139.Migrations
{
    /// <inheritdoc />
    public partial class AddLocationAndSeedEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Events",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableTickets", "Date", "Location", "Title" },
                values: new object[] { 50, new DateTime(2025, 10, 20, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6588), "London, UK", "Adele Live" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableTickets", "Date", "Location", "Title" },
                values: new object[] { 100, new DateTime(2025, 10, 25, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6594), "Toronto, Canada", "The Weeknd World Tour" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableTickets", "Date", "Location", "Title" },
                values: new object[] { 200, new DateTime(2025, 10, 30, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6596), "Paris, France", "Coldplay Stadium Show" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableTickets", "Date", "Location", "TicketPrice", "Title" },
                values: new object[] { 75, new DateTime(2025, 11, 4, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6597), "New York, USA", 250.00m, "Taylor Swift: The Eras Tour" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvailableTickets", "Date", "Location", "TicketPrice", "Title" },
                values: new object[] { 150, new DateTime(2025, 11, 9, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6599), "Seoul, South Korea", 180.00m, "BTS Reunion" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvailableTickets", "Date", "Location", "TicketPrice", "Title" },
                values: new object[] { 120, new DateTime(2025, 11, 14, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6600), "Dublin, Ireland", 95.00m, "Ed Sheeran Acoustic Night" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvailableTickets", "Date", "Location", "TicketPrice", "Title" },
                values: new object[] { 200, new DateTime(2025, 11, 19, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6602), "Berlin, Germany", 300.00m, "Champions League Final" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvailableTickets", "Date", "Location", "TicketPrice", "Title" },
                values: new object[] { 180, new DateTime(2025, 11, 24, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6603), "Los Angeles, USA", 350.00m, "NBA All-Star Game" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvailableTickets", "Date", "Location", "TicketPrice", "Title" },
                values: new object[] { 80, new DateTime(2025, 11, 29, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6604), "London, UK", 220.00m, "Wimbledon Finals" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvailableTickets", "Date", "Location", "TicketPrice", "Title" },
                values: new object[] { 300, new DateTime(2025, 12, 4, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6606), "Las Vegas, USA", 500.00m, "Super Bowl LX" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvailableTickets", "Date", "Location", "TicketPrice", "Title" },
                values: new object[] { 250, new DateTime(2025, 12, 9, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6607), "Monaco", 400.00m, "Formula 1 Grand Prix" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvailableTickets", "Date", "Location", "TicketPrice", "Title" },
                values: new object[] { 500, new DateTime(2025, 12, 14, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6608), "Tokyo, Japan", 450.00m, "Olympics Opening Ceremony" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvailableTickets", "Date", "Title" },
                values: new object[] { 500, new DateTime(2025, 10, 20, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7072), "Taylor Swift: The Eras Tour" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvailableTickets", "Date", "Title" },
                values: new object[] { 400, new DateTime(2025, 10, 30, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7078), "Coldplay: Music of the Spheres" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvailableTickets", "Date", "Title" },
                values: new object[] { 300, new DateTime(2025, 11, 9, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7080), "Billie Eilish Live" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvailableTickets", "Date", "TicketPrice", "Title" },
                values: new object[] { 350, new DateTime(2025, 11, 19, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7081), 100.00m, "Bruno Mars Night" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvailableTickets", "Date", "TicketPrice", "Title" },
                values: new object[] { 4, new DateTime(2025, 11, 29, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7083), 200.00m, "Adele: One Night Only" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvailableTickets", "Date", "TicketPrice", "Title" },
                values: new object[] { 450, new DateTime(2025, 12, 9, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7084), 130.00m, "Ed Sheeran: Mathematics Tour" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvailableTickets", "Date", "TicketPrice", "Title" },
                values: new object[] { 1000, new DateTime(2025, 10, 25, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7085), 90.00m, "NBA Finals Game 1" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvailableTickets", "Date", "TicketPrice", "Title" },
                values: new object[] { 2000, new DateTime(2025, 11, 4, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7086), 250.00m, "Super Bowl LVIII" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvailableTickets", "Date", "TicketPrice", "Title" },
                values: new object[] { 1500, new DateTime(2025, 11, 14, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7087), 75.00m, "World Cup Qualifier" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvailableTickets", "Date", "TicketPrice", "Title" },
                values: new object[] { 1200, new DateTime(2025, 11, 24, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7089), 95.00m, "Stanley Cup Final" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvailableTickets", "Date", "TicketPrice", "Title" },
                values: new object[] { 500, new DateTime(2025, 12, 4, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7090), 180.00m, "Wimbledon Finals" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvailableTickets", "Date", "TicketPrice", "Title" },
                values: new object[] { 800, new DateTime(2025, 12, 14, 16, 40, 51, 28, DateTimeKind.Utc).AddTicks(7091), 160.00m, "Olympic Track Finals" });
        }
    }
}
