using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Assignment_1___COMP2139.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePurchaseRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseEvents",
                table: "PurchaseEvents");

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Purchases");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PurchaseEvents",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "PurchaseEvents",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Events",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseEvents",
                table: "PurchaseEvents",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 10, 24, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 10, 29, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 11, 3, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 11, 8, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 11, 13, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 11, 18, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 11, 23, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 11, 28, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 12, 3, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 12, 8, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 12, 13, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 12, 18, 19, 4, 16, 879, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseEvents_PurchaseId",
                table: "PurchaseEvents",
                column: "PurchaseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseEvents",
                table: "PurchaseEvents");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseEvents_PurchaseId",
                table: "PurchaseEvents");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PurchaseEvents");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "PurchaseEvents");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCost",
                table: "Purchases",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Events",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseEvents",
                table: "PurchaseEvents",
                columns: new[] { "PurchaseId", "EventId" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 10, 20, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 10, 25, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 10, 30, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 11, 4, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 11, 9, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 11, 14, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 11, 19, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 11, 24, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 11, 29, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 12, 4, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 12, 9, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 12, 14, 17, 8, 53, 997, DateTimeKind.Utc).AddTicks(6608));
        }
    }
}
