using Microsoft.EntityFrameworkCore.Migrations;

namespace NintendoStore.Migrations
{
    public partial class seedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, null, "Mario Games" },
                    { 2, null, "The Legend of Zelda Games" },
                    { 3, null, "Donkey Kong Games" },
                    { 4, null, "Nintendo Favorites" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsonSale", "Name", "Price" },
                values: new object[] { 1, 1, "Keep Cool with Mario", "~\\Images\\NinetndoLogo.png", "~\\Images\\MarioSunshine.png", true, true, "Super Mario Sunshine", 50.00m });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsonSale", "Name", "Price" },
                values: new object[] { 2, 2, "Save Hyrule", "~\\Images\\OcarinaThumbnail.png", "~\\Images\\LegendofZelda.png", true, true, "The Legend of Zelda, Ocarina of Time", 40.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
