using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurritoAPI.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Burritos",
                columns: new[] { "BurritoId", "ImageUrl", "Location", "Name", "Price", "Protein", "Rating", "Review", "User" },
                values: new object[,]
                {
                    { 1, null, "Beto's", "Pastor Burrito", 11.00m, "Pork", 8.8000000000000007, "Very juicy pork, choice of black or pinto beans with rice, cheese, sour cream, onions, and cilantro. All salsas included are high quality and not watery.", "Gabe" },
                    { 2, null, "Los Gorditos", "Veggie Soy Curl Burrito", 12.00m, "Soy Curls", 8.1999999999999993, "Best vegetarian option in town. Comes with fajita veggies, beans, rice, sour cream, and cheese. Salsa bar is not to be slept on.", "Gabe" },
                    { 3, null, "Taqueria Santa Cruz", "Pollo Burrito Supreme", 9.00m, "Chicken", 8.5, "review here", "Gabe" },
                    { 4, null, "Pepinos", "Asada Burrito Supremo", 14.00m, "Beef", 8.4000000000000004, "Review Here", "Ravin" },
                    { 5, null, "Korean Twist", "Beef Bulgogi Burrito", 11.00m, "Beef", 8.9000000000000004, "Review Here", "Ravin" },
                    { 6, null, "Muchas Gracias", "Double Bacon Breakfast Burrito", 8.00m, "Pork", 7.7000000000000002, "Review Here", "Ravin" },
                    { 7, null, "King Burrito", "King Burito add Rice", 6.00m, "Beef", 8.1999999999999993, "Review Here", "Ravin" },
                    { 8, null, "La Bonita", "Carnitas Burrito", 10.75m, "Beef", 8.0999999999999996, "Review Here", "Noah" },
                    { 9, null, "Birria Pepe Chile", "Birria Burrito", 10.00m, "Beef", 8.6999999999999993, "Review Here", "Noah" },
                    { 10, null, "Tito's", "Shrimp Burrito", 11.00m, "Shrimp", 8.3000000000000007, "Review Here", "Noah" }
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
        }
    }
}
