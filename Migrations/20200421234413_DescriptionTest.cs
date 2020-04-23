using Microsoft.EntityFrameworkCore.Migrations;

namespace NintendoStore.Migrations
{
    public partial class DescriptionTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Seeking well-deserved rest and relaxation, Mario and Princess Peach travel to a beautiful remote island. It is said the local citizens are friendly and the weather forecast suggests year-round sunshine. However, when they get to the island, they quickly find out that the peaceful paradise has been polluted by a mysterious stranger who bears a striking resemblance to Mario! Determined to clear his reputation and clean up the island, Mario sets off on his greatest adventure yet.", "A villain resembling Mario, known as Shadow Mario, vandalizes the island with graffiti as Mario gets blamed for the mess. Mario is ordered to clean up Isle Delfino, using a device called the Flash Liquidizer Ultra Dousing Device (F.L.U.D.D.), while saving Princess Peach from Shadow Mario." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Keep Cool with Mario", "it me" });
        }
    }
}
