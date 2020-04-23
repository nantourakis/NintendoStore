using Microsoft.EntityFrameworkCore.Migrations;

namespace NintendoStore.Migrations
{
    public partial class updatingColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GameSystem",
                table: "Games",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "GameSystem", "ImageUrl" },
                values: new object[] { "NintendoStore GameCube", "\\Images\\SunshineMain.jpg" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "GameSystem", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Nintendo 64", "\\Images\\LegendofZelda.png", "\\Images\\OcarinaThumbnail.png" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "GameSystem", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Nintendo Switch", "\\Images\\DonkeyTropical.jpg", "\\Images\\DKTropicalThumbnail.jpg" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                columns: new[] { "GameSystem", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Nintendo GameCube", "\\Images\\SmashMeleeMain.jpg", "\\Images\\SmashMeleeThumb.jpg" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "CategoryId", "Description", "GameSystem", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsonSale", "Name", "Price" },
                values: new object[] { 5, 1, "On a bright, sunny day in the Mushroom Kingdom, Mario goes to visit the princess but finds her castle eerily empty. Leaping through pictures hanging from the walls, he enters 15 magical worlds in a quest to collect the 120 Power Stars pilfered by evil Bowser and save the day. This is the first platformer in the Super Mario series to feature three-dimensional gameplay.", "Nintendo 64", "\\Images\\SuperMario64Thumb", "\\Images\\SuperMario64Main", true, true, "Super Mario 64", 100.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "GameSystem",
                table: "Games");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "ImageUrl",
                value: "\\Images\\MarioSunshine.png");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\OcarinaThumbnail.png", "\\Images\\LegendofZelda.png" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\DKTropicalThumbnail.jpg", "\\Images\\DonkeyTropical.jpg" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "\\Images\\SmashMeleeThumb.jpg", "\\Images\\SmashMeleeMain.jpg" });
        }
    }
}
