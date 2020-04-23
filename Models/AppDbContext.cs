using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Models
{
    //IdentityDB - bring in to be the bridge between our application and our database, apply to our identtity user
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        //pass in DB options to the constructor and apply it to our class where we will be using it
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
        }

        //now tell our db context what data sets/Models its going to manage
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }
        // also add data set for shopping cart item Model
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        // Add DB connection string to appsettings.JSON file

        // create data model to populate db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //to get access/set up to the Category entity
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Mario Games" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "The Legend of Zelda Games" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Donkey Kong Games" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Nintendo Favorites" });

            //to get access/set up to the Game entity
            modelBuilder.Entity<Game>().HasData(new Game 
            { 
                GameId = 1,
                Name = "Super Mario Sunshine",
                Price = 50.00M,
                Description = "Seeking well-deserved rest and relaxation, Mario and Princess Peach travel to a beautiful remote island. It is said the local citizens are friendly and the weather " +
                "forecast suggests year-round sunshine. However, when they get to the island, they quickly find out that the peaceful paradise has been polluted by a mysterious stranger who bears a striking resemblance to Mario! " +
                "Determined to clear his reputation and clean up the island, Mario sets off on his greatest adventure yet.",
                CategoryId = 1,
                ImageUrl = "\\Images\\SunshineMain.jpg",
                ImageThumbnailUrl = "\\Images\\MarioSunshine.png",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Only for Nintendo GameCube",
                ShortDescription = "Mario is determined to clear his reputation as villain resembling him vandalizes the beutiful Isle Delfino.",
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 2,
                Name = "The Legend of Zelda, Ocarina of Time",
                Price = 40.00M,
                Description = "The player controls Link in the fantasy land of Hyrule on a quest to stop the evil king Ganondorf, traveling through time and navigating dungeons and an overworld. The game introduced features such as a target-lock system and context-sensitive buttons that have since become common in 3D adventure games." +
                " Music plays an important role, as the player must learn to play numerous songs on an ocarina to progress.",
                CategoryId = 2,
                ImageUrl = "\\Images\\OcarinaThumbnail.png",
                ImageThumbnailUrl = "\\Images\\LegendofZelda.png",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Only Nintendo 64",
                ShortDescription = "This is the origin of the Triforce, and the tale of the first exploits of Princess Zelda and the heroic adventurer Link."
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 3,
                Name = "Donkey Kong Country: Tropical Freeze",
                Price = 30.00M,
                Description = "Arctic invaders have turned Donkey Kong Island into their personal frozen fortress, and it’s up to you to save the day." +
                " Play as Donkey Kong in Original Mode and team up with Diddy Kong, Dixie Kong, and Cranky Kong - each with unique abilities to overcome platforming challenges and frosty foes.",
                CategoryId = 3,
                ImageUrl = "\\Images\\DKTropicalThumbnail.jpg",
                ImageThumbnailUrl = "\\Images\\DonkeyTropical.jpg",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Originally for Nintendo Wii U",
                ShortDescription = "Overcome challenges, battle frosty foes and bosses, and reclaim the Kongs’ stolen home."
            });
          modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 4,
                Name = "Super Smash Bros. Melee",
                Price = 100.00M,
                Description = "Normally, Nintendo players such as Mario, Pikachu, Link, Donkey Kong, Bowser, and Kirby are generally happy and well-mannered, but in Super Smash Bros. Melee, the pleasantries get thrown out and the gloves (except for Mario's) come off. " +
                "This update of the N64 favorite features these and other video game icons in furious frenzy that usually make for a smashing good time.",
                CategoryId = 4,
                ImageUrl = "\\Images\\SmashMeleeThumb.jpg",
                ImageThumbnailUrl = "\\Images\\SmashMeleeMain.jpg",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Only for Nintendo GameCube",
                ShortDescription = "Can Mario beat Donkey Kong? Is Pikachu tougher than Yoshi? Find out as 12 of Nintendo's biggest stars battle in head-to-head competition!"
          });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 5,
                Name = "Super Mario 64",
                Price = 80.00M,
                Description = "On a bright, sunny day in the Mushroom Kingdom, Mario goes to visit the princess but finds her castle eerily empty. Leaping through pictures hanging from the walls," +
                " he enters 15 magical worlds in a quest to collect the 120 Power Stars pilfered by evil Bowser and save the day. This is the first platformer in the Super Mario series to feature three-dimensional gameplay.",
                CategoryId = 1,
                ImageUrl = "\\Images\\SuperMario64Main.png",
                ImageThumbnailUrl = "\\Images\\SuperMario64Thumb.jfif",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Originally for Nintendo 64",
                ShortDescription = "Super Mario 64 is acclaimed as one of the greatest video games of all time, and was the first game to receive a perfect score from Edge magazine."
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 6,
                Name = "The Legend of Zelda: Link's Awakening",
                Price = 40.00M,
                Description = "Link has washed ashore on a mysterious island with strange and colorful inhabitants. To escape the island, Link must collect magical instruments across the land and awaken the Wind Fish." +
                " Explore a reimagined Koholint Island that's been faithfully rebuilt in a brand-new art style that will entice fans and newcomers alike.",
                CategoryId = 2,
                ImageUrl = "\\Images\\LinksAwakening.jpg",
                ImageThumbnailUrl = "\\Images\\LinksAwakeningThumb.jfif",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Only Nintendo Switch",
                ShortDescription = "Battle enemies as you conquer numerous dungeons and uncover the hidden secrets of the island."
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 7,
                Name = "Donkey Kong Country",
                Price = 80.00M,
                Description = "After a dark and stormy night, Donkey Kong finds all of his bananas stolen by K. Rool and his reptilian crew of Kremlings! Armed with chest-pounding muscle," +
                " mighty barrel rolls, and awesome vine-swinging skills, Donkey Kong and Diddy Kong set out to face their adversaries!",
                CategoryId = 3,
                ImageUrl = "\\Images\\DonkeyCountryMain.jpg",
                ImageThumbnailUrl = "\\Images\\DonkeyCountry.jpg",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Only for Super Nintendo",
                ShortDescription = "With the help of Donkey Kong's quirky family and animal friends, our dynamic duo will prove to be an unstoppable force. Time to save those bananas!"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 8,
                Name = "Donkey Kong Jungle Beat",
                Price = 50.00M,
                Description = " Donkey Kong sets out to prove he's king of the jungle and beyond. He rampages through lava caves, savage seas and crazy locales like a ninja-chimp fortress. Only when Donkey Kong defeats all the kings of his world – by boxing with apes, rabid warthogs, ballistic elephants and giant birds – can he call himself king.",
                CategoryId = 3,
                ImageUrl = "\\Images\\DKKongoBeatMain.jpg",
                ImageThumbnailUrl = "\\Images\\DKKongoBeat.jpg",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Originally for GameCube",
                ShortDescription = "Donkey Kong: Jungle Beat is a unique take on the Donkey Kong series, swapping out traditional controllers for bongo peripherals!"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 9,
                Name = "Donkey Kong Classic",
                Price = 200.00M,
                Description = "Donkey Kong is the original and much loved arcade game that introduced us to Mario for the first time and spawned an entire genre of platform games. Rescue the Princess and see how high you can go!",
                CategoryId = 3,
                ImageUrl = "\\Images\\DKOGMainn.jpg",
                ImageThumbnailUrl = "\\Images\\DKMain.jpg",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Classic Arcade Game",
                ShortDescription = "Help our hero ascend the metal structure by dodging an assortment of fireballs, steel beams, and exploding barrels the angry ape hurls at him."
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 10,
                Name = "Super Mario Bros. 3",
                Price = 80.00M,
                Description = "Bowser and the Koopalings are causing chaos yet again, but this time they’re going beyond the Mushroom Kingdom into the seven worlds that neighbor it. Now Mario and Luigi must battle a variety of enemies, including a Koopaling in each unique and distinctive world, on their way to ultimately taking on Bowser himself. Lucky for the brothers, they have more power-ups available than ever before." +
                " Fly above the action using the Super Leaf, swim faster by donning the Frog Suit, or defeat enemies using the Hammer Bros. Suit. ",
                CategoryId = 1,
                ImageUrl = "\\Images\\MarioBros3Main.png",
                ImageThumbnailUrl = "\\Images\\MarioBrosThumb.jpg",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Nintendo Entertainment System",
                ShortDescription = "Help Mario and Luigi recover the royal magic wands from Bowser's seven kids and return the kings to their true forms."
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 11,
                Name = "Paper Mario: The Thousand-Year Door",
                Price = 25.00M,
                Description = "Get ready for a two-dimensional role-playing adventure for the ages as Mario returns to paper form in pursuit of a threat unlike any he's ever faced. This time around, more emphasis is placed on the paper abilities of Mario and his friends. " +
                "He can turn sideways to slip through cracks, fold into a paper airplane to fly, roll into a tube, and much more. He can also use tons of items like hammers and thunderbolts.",
                CategoryId = 1,
                ImageUrl = "\\Images\\PaperMarioMain.png",
                ImageThumbnailUrl = "\\Images\\PaperMarioThumb.jpg",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Originally for Nintendo GameCube",
                ShortDescription = "Time passes, the pages turn ... and a new chapter unfolds in an unfamiliar land!"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 12,
                Name = "The Legend of Zelda: The Wind Waker",
                Price = 40.00M,
                Description = "In this timeless classic with a unique and colorful “toon-shaded” art style, players guide Link as he sets out on the massive Great Sea to find his kidnapped sister. " +
                "Players will sail the seas in search of lost islands, fight fearsome enemies, take on mighty bosses and seek out the legendary Triforce.",
                CategoryId = 2,
                ImageUrl = "\\Images\\WindWakerMain.png",
                ImageThumbnailUrl = "\\Images\\WindWakerThumb.jpg",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Originally for Nintendo GameCube",
                ShortDescription = "Link back on the GameCube with a fun new look, but the game is still serious about adventure."
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 13,
                Name = "Hyrule Warriors",
                Price = 30.00M,
                Description = "The Sorceress Cia has begun her conquest of Hyrule. Great armies of good and evil are clashing, but the tide of battle can be changed by a single, powerful warrior. As the conflict unfolds and objectives change, use special weapons and items to fight your way through hordes of enemies." +
                " You can even find materials on the battlefield to upgrade your characters and weapons for future battles.",
                CategoryId = 2,
                ImageUrl = "\\Images\\HyruleMain.jpg",
                ImageThumbnailUrl = "\\Images\\Hyrule-WarriorsThumb.jfif",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Originally for Nintendo Wii U",
                ShortDescription = "Cut down entire legions of enemies as Link, Zelda and other characters from the franchise using powerful Dynasty Warriors-style moves."
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 14,
                Name = "Mario Kart 8 Deluxe",
                Price = 50.00M,
                Description = "Hit the road with the definitive version of Mario Kart 8 - Feel the rush as your kart rockets across the ceiling! Race upside-down and along walls on anti-gravity tracks in the most action-fueled Mario Kart game yet!",
                CategoryId = 4,
                ImageUrl = "\\Images\\MarioMain.jpg",
                ImageThumbnailUrl = "\\Images\\MarioKartThumb.jpg",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Only for Nintendo Switch",
                ShortDescription = "Who doesn't love throwing turtle shells?!"
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 15,
                Name = "Mario Tennis Aces",
                Price = 50.00M,
                Description = "ario steps onto the court in classy tennis garb for intense rallies against a variety of characters in full-blown tennis battles. New wrinkles in tennis gameplay will challenge your ability to read an opponent's position and stroke to determine which shot will give you the advantage. " +
                "And this time the game adds the first story mode since the Mario Tennis game on the Game Boy offering a new flavor of tennis gameplay, with a variety of missions, boss battles and more.",
                CategoryId = 4,
                ImageUrl = "\\Images\\MarioTennisMain.jpg",
                ImageThumbnailUrl = "\\Images\\MatioTennisThumb.jpeg",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Only for Nintendo Switch",
                ShortDescription = "Unleash an arsenal of shots and strategies in all-out tennis battles with friends, family, and fan-favorite Mushroom Kingdom characters."
            });
            modelBuilder.Entity<Game>().HasData(new Game
            {
                GameId = 16,
                Name = "Diddy Kong Racing",
                Price = 90.00M,
                Description = "Timber the Tiger's parents picked a fine time to go on vacation. When they come back they're going to be faced with an island trashed by the spiteful space bully Wizpig - unless the local animals can do something about it! Join Diddy Kong as he teams up with Timber the Tiger, Pipsy the Mouse and Taj the Genie in an epic racing adventure unlike anything you've ever experienced before! This unique game blends adventure and racing like no other game!" +
                "Roam anywhere you want on the island by car plane or hovercraft! An enormous amount of single-player and multi-player modes!",
                CategoryId = 4,
                ImageUrl = "\\Images\\DiddyRacingMain.jpg",
                ImageThumbnailUrl = "\\Images\\DiddyRacingThumb.jpg",
                IsInStock = true,
                IsonSale = true,
                GameSystem = "Originally for Nintendo 64",
                ShortDescription = "Race with Diddy Kong and Friends!"
            });
        }
    }
}
