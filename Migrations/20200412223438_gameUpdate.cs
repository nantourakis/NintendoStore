using Microsoft.EntityFrameworkCore.Migrations;

namespace NintendoStore.Migrations
{
    public partial class gameUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "CategoryId", "Description", "GameSystem", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsonSale", "Name", "Price" },
                values: new object[,]
                {
                    { 6, 2, "Save Hyrule", "Only Nintendo Switch", "\\Images\\LinksAwakeningThumb.jfif", "\\Images\\LinksAwakening.jpg", true, true, "The Legend of Zelda: Link's Awakening", 40.00m },
                    { 7, 3, "get Bananas", "Only for Super Nintendo", "\\Images\\DonkeyCountry.jpg", "\\Images\\DonkeyCountryMain.jpg", true, true, "Donkey Kong Country", 40.00m },
                    { 8, 3, "get Bananas", "Only for Super Nintendo", "\\Images\\DKKongoBeat.jpg", "\\Images\\DKKongoBeatMain.jpg", true, true, "Donkey Kong Jungle Beat", 40.00m },
                    { 9, 3, "OG Bananas", "Classic Arcade Game", "\\Images\\DKMain.jpg", "\\Images\\DKOGMainn.jpg", true, true, "Donkey Kong", 40.00m },
                    { 10, 1, "Keep Cool with Mario", "Nintendo Entertainment System", "\\Images\\MarioBrosThumb.jpg", "\\Images\\MarioBros3Main.png", true, true, "Super Mario Bros. 3", 50.00m },
                    { 11, 1, "Paper Mario", "Only for Nintendo GameCube", "\\Images\\PaperMarioThumb.jpg", "\\Images\\PaperMarioMain.png", true, true, "Paper Mario: The Thousand-Year Door", 50.00m },
                    { 12, 2, "Save Hyrule", "Only Nintendo 64", "\\Images\\WindWakerThumb.jpg", "\\Images\\WindWakerMain.png", true, true, "The Legend of Zelda: The Wind Waker", 40.00m },
                    { 13, 2, "Save Hyrule", "Nintendo Wii U", "\\Images\\Hyrule-WarriorsThumb.jfif", "\\Images\\HyruleMain.jpg", true, true, "Hyrule Warriors", 40.00m },
                    { 14, 4, "The imaginative world of Nintendo is brought to life by the staggering processing ", "Only for Nintendo Switch", "\\Images\\MarioKartThumb.jpg", "\\Images\\MarioMain.jpg", true, true, "Mario Kart 8 Deluxe", 100.00m },
                    { 15, 4, "The imaginative world of Nintendo is brought to life by the staggering processing ", "Only for Nintendo Switch", "\\Images\\MatioTennisThumb.jpeg", "\\Images\\MarioTennisMain.jpg", true, true, "Mario Tennis Aces", 100.00m },
                    { 16, 4, "The imaginative world of Nintendo is brought to life by the staggering processing ", "Only for Nintendo 64", "\\Images\\DiddyRacingThumb.jpg", "\\Images\\DiddyRacingMain.jpg", true, true, "Diddy Kong Racing", 100.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 16);
        }
    }
}
