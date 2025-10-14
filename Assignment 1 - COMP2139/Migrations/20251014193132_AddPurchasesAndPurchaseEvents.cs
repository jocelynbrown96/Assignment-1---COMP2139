using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Assignment_1___COMP2139.Migrations
{
    /// <inheritdoc />
    public partial class AddPurchasesAndPurchaseEvents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseEvents",
                table: "PurchaseEvents");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseEvents_PurchaseId",
                table: "PurchaseEvents");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PurchaseEvents",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PurchaseEvents",
                table: "PurchaseEvents",
                columns: new[] { "PurchaseId", "EventId" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 10, 24, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 10, 29, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 11, 3, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 11, 8, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2025, 11, 13, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2025, 11, 18, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2025, 11, 23, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2025, 11, 28, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2025, 12, 3, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2025, 12, 8, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2025, 12, 13, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2025, 12, 18, 19, 31, 31, 954, DateTimeKind.Utc).AddTicks(9574));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PurchaseEvents",
                table: "PurchaseEvents");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PurchaseEvents",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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
    }
}
