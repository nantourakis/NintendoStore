using Microsoft.EntityFrameworkCore.Migrations;

namespace NintendoStore.Migrations
{
    public partial class UpdatedPrices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "ShortDescription",
                value: "Mario is determined to clear his reputation as villain resembling him vandalizes the beutiful Isle Delfino.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "Description", "GameSystem", "Price" },
                values: new object[] { "Arctic invaders have turned Donkey Kong Island into their personal frozen fortress, and it’s up to you to save the day. Play as Donkey Kong in Original Mode and team up with Diddy Kong, Dixie Kong, and Cranky Kong - each with unique abilities to overcome platforming challenges and frosty foes.", "Originally for Nintendo Wii U", 30.00m });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                column: "Price",
                value: 80.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                column: "Price",
                value: 80.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                column: "Price",
                value: 50.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                column: "Price",
                value: 200.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                column: "Price",
                value: 80.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                columns: new[] { "GameSystem", "Price" },
                values: new object[] { "Originally for Nintendo GameCube", 25.00m });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                column: "ShortDescription",
                value: "Link back on the GameCube with a fun new look, but the game is still serious about adventure.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 13,
                columns: new[] { "GameSystem", "Price", "ShortDescription" },
                values: new object[] { "Originally for Nintendo Wii U", 30.00m, "Cut down entire legions of enemies as Link, Zelda and other characters from the franchise using powerful Dynasty Warriors-style moves." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 14,
                column: "Price",
                value: 50.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 15,
                column: "Price",
                value: 50.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 16,
                column: "Price",
                value: 90.00m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "ShortDescription",
                value: "Mario is determined to clear his reputation as villain resembling him vandalizes the beutiful Isle Delfino");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "Description", "GameSystem", "Price" },
                values: new object[] { "Arctic invaders have turned Donkey Kong Island into their personal frozen fortress, and it’s up to you to save the day. Play as Donkey Kong in Original Mode and team up with Diddy Kong, Dixie Kong, and Cranky Kong—each with unique abilities—to overcome platforming challenges and frosty foes.", "Nintendo Wii & Nintendo Switch", 40.00m });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                column: "Price",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                column: "Price",
                value: 40.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                column: "Price",
                value: 40.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                column: "Price",
                value: 40.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                column: "Price",
                value: 50.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                columns: new[] { "GameSystem", "Price" },
                values: new object[] { "Only for Nintendo GameCube", 50.00m });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                column: "ShortDescription",
                value: "Link back on the GameCube with a fun new look, but the game is still serious about adventure");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 13,
                columns: new[] { "GameSystem", "Price", "ShortDescription" },
                values: new object[] { "Nintendo Wii U", 40.00m, "Cut down entire legions of enemies as Link, Zelda and other characters from The Legend of Zelda franchise using over-the-top powerful Dynasty Warriors-style moves." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 14,
                column: "Price",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 15,
                column: "Price",
                value: 100.00m);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 16,
                column: "Price",
                value: 100.00m);
        }
    }
}
