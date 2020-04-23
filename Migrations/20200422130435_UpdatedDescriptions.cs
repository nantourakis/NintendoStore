using Microsoft.EntityFrameworkCore.Migrations;

namespace NintendoStore.Migrations
{
    public partial class UpdatedDescriptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 2,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "The player controls Link in the fantasy land of Hyrule on a quest to stop the evil king Ganondorf, traveling through time and navigating dungeons and an overworld. The game introduced features such as a target-lock system and context-sensitive buttons that have since become common in 3D adventure games. Music plays an important role, as the player must learn to play numerous songs on an ocarina to progress.", "This is the origin of the Triforce, and the tale of the first exploits of Princess Zelda and the heroic adventurer Link." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "Description", "GameSystem", "ShortDescription" },
                values: new object[] { "Arctic invaders have turned Donkey Kong Island into their personal frozen fortress, and it’s up to you to save the day. Play as Donkey Kong in Original Mode and team up with Diddy Kong, Dixie Kong, and Cranky Kong—each with unique abilities—to overcome platforming challenges and frosty foes.", "Nintendo Wii & Nintendo Switch", "Overcome challenges, battle frosty foes and bosses, and reclaim the Kongs’ stolen home." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Normally, Nintendo players such as Mario, Pikachu, Link, Donkey Kong, Bowser, and Kirby are generally happy and well-mannered, but in Super Smash Bros. Melee, the pleasantries get thrown out and the gloves (except for Mario's) come off. This update of the N64 favorite features these and other video game icons in furious frenzy that usually make for a smashing good time.", "Can Mario beat Donkey Kong? Is Pikachu tougher than Yoshi? Find out as 12 of Nintendo's biggest stars battle in head-to-head competition!" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                columns: new[] { "GameSystem", "ShortDescription" },
                values: new object[] { "Originally for Nintendo 64", "Super Mario 64 is acclaimed as one of the greatest video games of all time, and was the first game to receive a perfect score from Edge magazine." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Link has washed ashore on a mysterious island with strange and colorful inhabitants. To escape the island, Link must collect magical instruments across the land and awaken the Wind Fish. Explore a reimagined Koholint Island that's been faithfully rebuilt in a brand-new art style that will entice fans and newcomers alike.", "Battle enemies as you conquer numerous dungeons and uncover the hidden secrets of the island." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "After a dark and stormy night, Donkey Kong finds all of his bananas stolen by K. Rool and his reptilian crew of Kremlings! Armed with chest-pounding muscle, mighty barrel rolls, and awesome vine-swinging skills, Donkey Kong and Diddy Kong set out to face their adversaries!", "With the help of Donkey Kong's quirky family and animal friends, our dynamic duo will prove to be an unstoppable force. Time to save those bananas!" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                columns: new[] { "Description", "GameSystem", "ShortDescription" },
                values: new object[] { " Donkey Kong sets out to prove he's king of the jungle and beyond. He rampages through lava caves, savage seas and crazy locales like a ninja-chimp fortress. Only when Donkey Kong defeats all the kings of his world – by boxing with apes, rabid warthogs, ballistic elephants and giant birds – can he call himself king.", "Originally for GameCube", "Donkey Kong: Jungle Beat is a unique take on the Donkey Kong series, swapping out traditional controllers for bongo peripherals!" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "ShortDescription" },
                values: new object[] { "Donkey Kong is the original and much loved arcade game that introduced us to Mario for the first time and spawned an entire genre of platform games. Rescue the Princess and see how high you can go!", "Donkey Kong Classic", "Help our hero ascend the metal structure by dodging an assortment of fireballs, steel beams, and exploding barrels the angry ape hurls at him." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Bowser and the Koopalings are causing chaos yet again, but this time they’re going beyond the Mushroom Kingdom into the seven worlds that neighbor it. Now Mario and Luigi must battle a variety of enemies, including a Koopaling in each unique and distinctive world, on their way to ultimately taking on Bowser himself. Lucky for the brothers, they have more power-ups available than ever before. Fly above the action using the Super Leaf, swim faster by donning the Frog Suit, or defeat enemies using the Hammer Bros. Suit. ", "Help Mario and Luigi recover the royal magic wands from Bowser's seven kids and return the kings to their true forms." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Get ready for a two-dimensional role-playing adventure for the ages as Mario returns to paper form in pursuit of a threat unlike any he's ever faced. This time around, more emphasis is placed on the paper abilities of Mario and his friends. He can turn sideways to slip through cracks, fold into a paper airplane to fly, roll into a tube, and much more. He can also use tons of items like hammers and thunderbolts.", "Time passes, the pages turn ... and a new chapter unfolds in an unfamiliar land!" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                columns: new[] { "Description", "GameSystem", "ShortDescription" },
                values: new object[] { "In this timeless classic with a unique and colorful “toon-shaded” art style, players guide Link as he sets out on the massive Great Sea to find his kidnapped sister. Players will sail the seas in search of lost islands, fight fearsome enemies, take on mighty bosses and seek out the legendary Triforce.", "Originally for Nintendo GameCube", "Link back on the GameCube with a fun new look, but the game is still serious about adventure" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 13,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "The Sorceress Cia has begun her conquest of Hyrule. Great armies of good and evil are clashing, but the tide of battle can be changed by a single, powerful warrior. As the conflict unfolds and objectives change, use special weapons and items to fight your way through hordes of enemies. You can even find materials on the battlefield to upgrade your characters and weapons for future battles.", "Cut down entire legions of enemies as Link, Zelda and other characters from The Legend of Zelda franchise using over-the-top powerful Dynasty Warriors-style moves." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 14,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Hit the road with the definitive version of Mario Kart 8 - Feel the rush as your kart rockets across the ceiling! Race upside-down and along walls on anti-gravity tracks in the most action-fueled Mario Kart game yet!", "Who doesn't love throwing turtle shells?!" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 15,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "ario steps onto the court in classy tennis garb for intense rallies against a variety of characters in full-blown tennis battles. New wrinkles in tennis gameplay will challenge your ability to read an opponent's position and stroke to determine which shot will give you the advantage. And this time the game adds the first story mode since the Mario Tennis game on the Game Boy offering a new flavor of tennis gameplay, with a variety of missions, boss battles and more.", "Unleash an arsenal of shots and strategies in all-out tennis battles with friends, family, and fan-favorite Mushroom Kingdom characters." });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 16,
                columns: new[] { "Description", "GameSystem", "ShortDescription" },
                values: new object[] { "Timber the Tiger's parents picked a fine time to go on vacation. When they come back they're going to be faced with an island trashed by the spiteful space bully Wizpig - unless the local animals can do something about it! Join Diddy Kong as he teams up with Timber the Tiger, Pipsy the Mouse and Taj the Genie in an epic racing adventure unlike anything you've ever experienced before! This unique game blends adventure and racing like no other game!Roam anywhere you want on the island by car plane or hovercraft! An enormous amount of single-player and multi-player modes!", "Originally for Nintendo 64", "Race with Diddy Kong and Friends!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 1,
                column: "ShortDescription",
                value: "A villain resembling Mario, known as Shadow Mario, vandalizes the island with graffiti as Mario gets blamed for the mess. Mario is ordered to clean up Isle Delfino, using a device called the Flash Liquidizer Ultra Dousing Device (F.L.U.D.D.), while saving Princess Peach from Shadow Mario.");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 2,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Save Hyrule", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 3,
                columns: new[] { "Description", "GameSystem", "ShortDescription" },
                values: new object[] { "get Bananas", "Only for Nintendo Switch", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 4,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "The imaginative world of Nintendo is brought to life by the staggering processing power of Nintendo GameCube in Super Smash Bros. Melee - the most furious, frenzied, frantic fighter of all-time! Choose from 14 of your all-time favorite Nintendo characters and fight using signature moves and weapons. Battle in arenas pulled right from the lush worlds of the Nintendo Universe.", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 5,
                columns: new[] { "GameSystem", "ShortDescription" },
                values: new object[] { "Only for Nintendo 64", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 6,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Save Hyrule", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 7,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "get Bananas", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 8,
                columns: new[] { "Description", "GameSystem", "ShortDescription" },
                values: new object[] { "get Bananas", "Only for Super Nintendo", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 9,
                columns: new[] { "Description", "Name", "ShortDescription" },
                values: new object[] { "OG Bananas", "Donkey Kong", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 10,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Keep Cool with Mario", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 11,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Paper Mario", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 12,
                columns: new[] { "Description", "GameSystem", "ShortDescription" },
                values: new object[] { "Save Hyrule", "Only Nintendo 64", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 13,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "Save Hyrule", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 14,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "The imaginative world of Nintendo is brought to life by the staggering processing ", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 15,
                columns: new[] { "Description", "ShortDescription" },
                values: new object[] { "The imaginative world of Nintendo is brought to life by the staggering processing ", "it me" });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "GameId",
                keyValue: 16,
                columns: new[] { "Description", "GameSystem", "ShortDescription" },
                values: new object[] { "The imaginative world of Nintendo is brought to life by the staggering processing ", "Only for Nintendo 64", "it me" });
        }
    }
}
