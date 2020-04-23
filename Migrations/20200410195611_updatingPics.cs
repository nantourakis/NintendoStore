using Microsoft.EntityFrameworkCore.Migrations;

namespace NintendoStore.Migrations
{
    public partial class updatingPics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "GameSystem",
                value: "Only for Nintendo GameCube");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "GameSystem",
                value: "Only Nintendo 64");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "GameSystem",
                value: "Only for Nintendo Switch");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                column: "GameSystem",
                value: "Only for Nintendo GameCube");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                columns: new[] { "GameSystem", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Only for Nintendo 64", "\\Images\\SuperMario64Thumb.jfif", "\\Images\\SuperMario64Main.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "GameSystem",
                value: "NintendoStore GameCube");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                column: "GameSystem",
                value: "Nintendo 64");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "GameSystem",
                value: "Nintendo Switch");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                column: "GameSystem",
                value: "Nintendo GameCube");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                columns: new[] { "GameSystem", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Nintendo 64", "\\Images\\SuperMario64Thumb", "\\Images\\SuperMario64Main" });
        }
    }
}
