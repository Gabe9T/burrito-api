using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurritoAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Protien",
                table: "Burritos",
                newName: "Protein");

            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Burritos",
                type: "double",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Burritos",
                columns: new[] { "BurritoId", "Location", "Name", "Price", "Protein", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "Beto's", "Pastor Burrito", 11.00m, "Pork", 8.8000000000000007, "Very juicy pork, choice of black or pinto beans with rice, cheese, sour cream, onions, and cilantro. All salsas included are high quality and not watery." },
                    { 2, "Los Gorditos", "Veggie Soy Curl Burrito", 12.00m, "Soy Curls", 8.1999999999999993, "Best vegetarian option in town. Comes with fajita veggies, beans, rice, sour cream, and cheese. Salsa bar is not to be slept on." },
                    { 3, "Taqueria Santa Cruz", "Pollo Burrito Supreme", 9.00m, "Chicken", 8.5, "review here" },
                    { 4, "Pepinos", "Asada Burrito Supremo", 14.00m, "Beef", 8.4000000000000004, "Review Here" },
                    { 5, "Korean Twist", "Beef Bulgogi Burrito", 11.00m, "Beef", 8.9000000000000004, "Review Here" },
                    { 6, "Muchas Gracias", "Double Bacon Breakfast Burrito", 8.00m, "Pork", 7.7000000000000002, "Review Here" },
                    { 7, "King Burrito", "King Burito add Rice", 6.00m, "Beef", 8.0999999999999996, "Review Here" },
                    { 8, "La Bonita", "Carnitas Burrito", 10.75m, "Beef", 8.0999999999999996, "Review Here" },
                    { 9, "Birria Pepe Chile", "Birria Burrito", 10.00m, "Beef", 8.6999999999999993, "Review Here" },
                    { 10, "Tito's", "Shrimp Burrito", 11.00m, "Shrimp", 8.3000000000000007, "Review Here" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Burritos",
                keyColumn: "BurritoId",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "Protein",
                table: "Burritos",
                newName: "Protien");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Burritos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double")
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
