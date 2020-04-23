using Microsoft.EntityFrameworkCore.Migrations;

namespace NintendoStore.Migrations
{
    public partial class newRow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\MarioSunshine.png", "\\Images\\MarioSunshine.png" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\OcarinaThumbnail.png", "\\Images\\LegendofZelda.png" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsonSale", "Name", "Price" },
                values: new object[] { 3, 3, "get Bananas", "\\Images\\DKTropicalThumbnail", "\\Images\\DonkeyTropical.jpg", true, true, "Donkey Kong Country: Tropical Freeze", 40.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\NinetndoLogo.png", "~\\Images\\MarioSunshine.png" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~\\Images\\OcarinaThumbnail.png", "~\\Images\\LegendofZelda.png" });
        }
    }
}
