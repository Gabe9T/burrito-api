using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurritoAPI.Migrations
{
    public partial class SeedDataUpdateForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Burritos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 1,
                column: "User",
                value: "Gabe");

            migrationBuilder.UpdateData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 2,
                column: "User",
                value: "Gabe");

            migrationBuilder.UpdateData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 3,
                column: "User",
                value: "Gabe");

            migrationBuilder.UpdateData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 4,
                column: "User",
                value: "Ravin");

            migrationBuilder.UpdateData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 5,
                column: "User",
                value: "Ravin");

            migrationBuilder.UpdateData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 6,
                column: "User",
                value: "Ravin");

            migrationBuilder.UpdateData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 7,
                columns: new[] { "Rating", "User" },
                values: new object[] { 8.1999999999999993, "Ravin" });

            migrationBuilder.UpdateData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 8,
                column: "User",
                value: "Noah");

            migrationBuilder.UpdateData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 9,
                column: "User",
                value: "Noah");

            migrationBuilder.UpdateData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 10,
                column: "User",
                value: "Noah");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "User",
                table: "Burritos");

            migrationBuilder.UpdateData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 7,
                column: "Rating",
                value: 8.0999999999999996);
        }
    }
}
