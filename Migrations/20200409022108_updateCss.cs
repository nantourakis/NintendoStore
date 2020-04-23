using Microsoft.EntityFrameworkCore.Migrations;

namespace NintendoStore.Migrations
{
    public partial class updateCss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "\\Images\\DKTropicalThumbnail.jpg");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsonSale", "Name", "Price" },
                values: new object[] { 4, 4, "The imaginative world of Nintendo is brought to life by the staggering processing power of Nintendo GameCube in Super Smash Bros. Melee - the most furious, frenzied, frantic fighter of all-time! Choose from 14 of your all-time favorite Nintendo characters and fight using signature moves and weapons. Battle in arenas pulled right from the lush worlds of the Nintendo Universe.", "\\Images\\SmashMeleeThumb.jpg", "\\Images\\SmashMeleeMain.jpg", true, true, "Super Smash Bros. Melee", 100.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "\\Images\\DKTropicalThumbnail");
        }
    }
}
