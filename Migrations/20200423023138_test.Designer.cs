﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NintendoStore.Models;

namespace NintendoStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200423023138_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NintendoStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Mario Games"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "The Legend of Zelda Games"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Donkey Kong Games"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Nintendo Favorites"
                        });
                });

            modelBuilder.Entity("NintendoStore.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsonSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            CategoryId = 1,
                            Description = "Seeking well-deserved rest and relaxation, Mario and Princess Peach travel to a beautiful remote island. It is said the local citizens are friendly and the weather forecast suggests year-round sunshine. However, when they get to the island, they quickly find out that the peaceful paradise has been polluted by a mysterious stranger who bears a striking resemblance to Mario! Determined to clear his reputation and clean up the island, Mario sets off on his greatest adventure yet.",
                            GameSystem = "Only for Nintendo GameCube",
                            ImageThumbnailUrl = "\\Images\\MarioSunshine.png",
                            ImageUrl = "\\Images\\SunshineMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Super Mario Sunshine",
                            Price = 50.00m,
                            ShortDescription = "Mario is determined to clear his reputation as villain resembling him vandalizes the beutiful Isle Delfino."
                        },
                        new
                        {
                            GameId = 2,
                            CategoryId = 2,
                            Description = "The player controls Link in the fantasy land of Hyrule on a quest to stop the evil king Ganondorf, traveling through time and navigating dungeons and an overworld. The game introduced features such as a target-lock system and context-sensitive buttons that have since become common in 3D adventure games. Music plays an important role, as the player must learn to play numerous songs on an ocarina to progress.",
                            GameSystem = "Only Nintendo 64",
                            ImageThumbnailUrl = "\\Images\\LegendofZelda.png",
                            ImageUrl = "\\Images\\OcarinaThumbnail.png",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "The Legend of Zelda, Ocarina of Time",
                            Price = 40.00m,
                            ShortDescription = "This is the origin of the Triforce, and the tale of the first exploits of Princess Zelda and the heroic adventurer Link."
                        },
                        new
                        {
                            GameId = 3,
                            CategoryId = 3,
                            Description = "Arctic invaders have turned Donkey Kong Island into their personal frozen fortress, and it’s up to you to save the day. Play as Donkey Kong in Original Mode and team up with Diddy Kong, Dixie Kong, and Cranky Kong - each with unique abilities to overcome platforming challenges and frosty foes.",
                            GameSystem = "Originally for Nintendo Wii U",
                            ImageThumbnailUrl = "\\Images\\DonkeyTropical.jpg",
                            ImageUrl = "\\Images\\DKTropicalThumbnail.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Donkey Kong Country: Tropical Freeze",
                            Price = 30.00m,
                            ShortDescription = "Overcome challenges, battle frosty foes and bosses, and reclaim the Kongs’ stolen home."
                        },
                        new
                        {
                            GameId = 4,
                            CategoryId = 4,
                            Description = "Normally, Nintendo players such as Mario, Pikachu, Link, Donkey Kong, Bowser, and Kirby are generally happy and well-mannered, but in Super Smash Bros. Melee, the pleasantries get thrown out and the gloves (except for Mario's) come off. This update of the N64 favorite features these and other video game icons in furious frenzy that usually make for a smashing good time.",
                            GameSystem = "Only for Nintendo GameCube",
                            ImageThumbnailUrl = "\\Images\\SmashMeleeMain.jpg",
                            ImageUrl = "\\Images\\SmashMeleeThumb.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Super Smash Bros. Melee",
                            Price = 100.00m,
                            ShortDescription = "Can Mario beat Donkey Kong? Is Pikachu tougher than Yoshi? Find out as 12 of Nintendo's biggest stars battle in head-to-head competition!"
                        },
                        new
                        {
                            GameId = 5,
                            CategoryId = 1,
                            Description = "On a bright, sunny day in the Mushroom Kingdom, Mario goes to visit the princess but finds her castle eerily empty. Leaping through pictures hanging from the walls, he enters 15 magical worlds in a quest to collect the 120 Power Stars pilfered by evil Bowser and save the day. This is the first platformer in the Super Mario series to feature three-dimensional gameplay.",
                            GameSystem = "Originally for Nintendo 64",
                            ImageThumbnailUrl = "\\Images\\SuperMario64Thumb.jfif",
                            ImageUrl = "\\Images\\SuperMario64Main.png",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Super Mario 64",
                            Price = 80.00m,
                            ShortDescription = "Super Mario 64 is acclaimed as one of the greatest video games of all time, and was the first game to receive a perfect score from Edge magazine."
                        },
                        new
                        {
                            GameId = 6,
                            CategoryId = 2,
                            Description = "Link has washed ashore on a mysterious island with strange and colorful inhabitants. To escape the island, Link must collect magical instruments across the land and awaken the Wind Fish. Explore a reimagined Koholint Island that's been faithfully rebuilt in a brand-new art style that will entice fans and newcomers alike.",
                            GameSystem = "Only Nintendo Switch",
                            ImageThumbnailUrl = "\\Images\\LinksAwakeningThumb.jfif",
                            ImageUrl = "\\Images\\LinksAwakening.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "The Legend of Zelda: Link's Awakening",
                            Price = 40.00m,
                            ShortDescription = "Battle enemies as you conquer numerous dungeons and uncover the hidden secrets of the island."
                        },
                        new
                        {
                            GameId = 7,
                            CategoryId = 3,
                            Description = "After a dark and stormy night, Donkey Kong finds all of his bananas stolen by K. Rool and his reptilian crew of Kremlings! Armed with chest-pounding muscle, mighty barrel rolls, and awesome vine-swinging skills, Donkey Kong and Diddy Kong set out to face their adversaries!",
                            GameSystem = "Only for Super Nintendo",
                            ImageThumbnailUrl = "\\Images\\DonkeyCountry.jpg",
                            ImageUrl = "\\Images\\DonkeyCountryMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Donkey Kong Country",
                            Price = 80.00m,
                            ShortDescription = "With the help of Donkey Kong's quirky family and animal friends, our dynamic duo will prove to be an unstoppable force. Time to save those bananas!"
                        },
                        new
                        {
                            GameId = 8,
                            CategoryId = 3,
                            Description = " Donkey Kong sets out to prove he's king of the jungle and beyond. He rampages through lava caves, savage seas and crazy locales like a ninja-chimp fortress. Only when Donkey Kong defeats all the kings of his world – by boxing with apes, rabid warthogs, ballistic elephants and giant birds – can he call himself king.",
                            GameSystem = "Originally for GameCube",
                            ImageThumbnailUrl = "\\Images\\DKKongoBeat.jpg",
                            ImageUrl = "\\Images\\DKKongoBeatMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Donkey Kong Jungle Beat",
                            Price = 50.00m,
                            ShortDescription = "Donkey Kong: Jungle Beat is a unique take on the Donkey Kong series, swapping out traditional controllers for bongo peripherals!"
                        },
                        new
                        {
                            GameId = 9,
                            CategoryId = 3,
                            Description = "Donkey Kong is the original and much loved arcade game that introduced us to Mario for the first time and spawned an entire genre of platform games. Rescue the Princess and see how high you can go!",
                            GameSystem = "Classic Arcade Game",
                            ImageThumbnailUrl = "\\Images\\DKMain.jpg",
                            ImageUrl = "\\Images\\DKOGMainn.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Donkey Kong Classic",
                            Price = 200.00m,
                            ShortDescription = "Help our hero ascend the metal structure by dodging an assortment of fireballs, steel beams, and exploding barrels the angry ape hurls at him."
                        },
                        new
                        {
                            GameId = 10,
                            CategoryId = 1,
                            Description = "Bowser and the Koopalings are causing chaos yet again, but this time they’re going beyond the Mushroom Kingdom into the seven worlds that neighbor it. Now Mario and Luigi must battle a variety of enemies, including a Koopaling in each unique and distinctive world, on their way to ultimately taking on Bowser himself. Lucky for the brothers, they have more power-ups available than ever before. Fly above the action using the Super Leaf, swim faster by donning the Frog Suit, or defeat enemies using the Hammer Bros. Suit. ",
                            GameSystem = "Nintendo Entertainment System",
                            ImageThumbnailUrl = "\\Images\\MarioBrosThumb.jpg",
                            ImageUrl = "\\Images\\MarioBros3Main.png",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Super Mario Bros. 3",
                            Price = 80.00m,
                            ShortDescription = "Help Mario and Luigi recover the royal magic wands from Bowser's seven kids and return the kings to their true forms."
                        },
                        new
                        {
                            GameId = 11,
                            CategoryId = 1,
                            Description = "Get ready for a two-dimensional role-playing adventure for the ages as Mario returns to paper form in pursuit of a threat unlike any he's ever faced. This time around, more emphasis is placed on the paper abilities of Mario and his friends. He can turn sideways to slip through cracks, fold into a paper airplane to fly, roll into a tube, and much more. He can also use tons of items like hammers and thunderbolts.",
                            GameSystem = "Originally for Nintendo GameCube",
                            ImageThumbnailUrl = "\\Images\\PaperMarioThumb.jpg",
                            ImageUrl = "\\Images\\PaperMarioMain.png",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Paper Mario: The Thousand-Year Door",
                            Price = 25.00m,
                            ShortDescription = "Time passes, the pages turn ... and a new chapter unfolds in an unfamiliar land!"
                        },
                        new
                        {
                            GameId = 12,
                            CategoryId = 2,
                            Description = "In this timeless classic with a unique and colorful “toon-shaded” art style, players guide Link as he sets out on the massive Great Sea to find his kidnapped sister. Players will sail the seas in search of lost islands, fight fearsome enemies, take on mighty bosses and seek out the legendary Triforce.",
                            GameSystem = "Originally for Nintendo GameCube",
                            ImageThumbnailUrl = "\\Images\\WindWakerThumb.jpg",
                            ImageUrl = "\\Images\\WindWakerMain.png",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "The Legend of Zelda: The Wind Waker",
                            Price = 40.00m,
                            ShortDescription = "Link back on the GameCube with a fun new look, but the game is still serious about adventure."
                        },
                        new
                        {
                            GameId = 13,
                            CategoryId = 2,
                            Description = "The Sorceress Cia has begun her conquest of Hyrule. Great armies of good and evil are clashing, but the tide of battle can be changed by a single, powerful warrior. As the conflict unfolds and objectives change, use special weapons and items to fight your way through hordes of enemies. You can even find materials on the battlefield to upgrade your characters and weapons for future battles.",
                            GameSystem = "Originally for Nintendo Wii U",
                            ImageThumbnailUrl = "\\Images\\Hyrule-WarriorsThumb.jfif",
                            ImageUrl = "\\Images\\HyruleMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Hyrule Warriors",
                            Price = 30.00m,
                            ShortDescription = "Cut down entire legions of enemies as Link, Zelda and other characters from the franchise using powerful Dynasty Warriors-style moves."
                        },
                        new
                        {
                            GameId = 14,
                            CategoryId = 4,
                            Description = "Hit the road with the definitive version of Mario Kart 8 - Feel the rush as your kart rockets across the ceiling! Race upside-down and along walls on anti-gravity tracks in the most action-fueled Mario Kart game yet!",
                            GameSystem = "Only for Nintendo Switch",
                            ImageThumbnailUrl = "\\Images\\MarioKartThumb.jpg",
                            ImageUrl = "\\Images\\MarioMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Mario Kart 8 Deluxe",
                            Price = 50.00m,
                            ShortDescription = "Who doesn't love throwing turtle shells?!"
                        },
                        new
                        {
                            GameId = 15,
                            CategoryId = 4,
                            Description = "ario steps onto the court in classy tennis garb for intense rallies against a variety of characters in full-blown tennis battles. New wrinkles in tennis gameplay will challenge your ability to read an opponent's position and stroke to determine which shot will give you the advantage. And this time the game adds the first story mode since the Mario Tennis game on the Game Boy offering a new flavor of tennis gameplay, with a variety of missions, boss battles and more.",
                            GameSystem = "Only for Nintendo Switch",
                            ImageThumbnailUrl = "\\Images\\MatioTennisThumb.jpeg",
                            ImageUrl = "\\Images\\MarioTennisMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Mario Tennis Aces",
                            Price = 50.00m,
                            ShortDescription = "Unleash an arsenal of shots and strategies in all-out tennis battles with friends, family, and fan-favorite Mushroom Kingdom characters."
                        },
                        new
                        {
                            GameId = 16,
                            CategoryId = 4,
                            Description = "Timber the Tiger's parents picked a fine time to go on vacation. When they come back they're going to be faced with an island trashed by the spiteful space bully Wizpig - unless the local animals can do something about it! Join Diddy Kong as he teams up with Timber the Tiger, Pipsy the Mouse and Taj the Genie in an epic racing adventure unlike anything you've ever experienced before! This unique game blends adventure and racing like no other game!Roam anywhere you want on the island by car plane or hovercraft! An enormous amount of single-player and multi-player modes!",
                            GameSystem = "Originally for Nintendo 64",
                            ImageThumbnailUrl = "\\Images\\DiddyRacingThumb.jpg",
                            ImageUrl = "\\Images\\DiddyRacingMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Diddy Kong Racing",
                            Price = 90.00m,
                            ShortDescription = "Race with Diddy Kong and Friends!"
                        });
                });

            modelBuilder.Entity("NintendoStore.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("NintendoStore.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("GameId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("NintendoStore.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("GameId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NintendoStore.Models.Game", b =>
                {
                    b.HasOne("NintendoStore.Models.Category", "Category")
                        .WithMany("Games")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NintendoStore.Models.OrderDetail", b =>
                {
                    b.HasOne("NintendoStore.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NintendoStore.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NintendoStore.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("NintendoStore.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");
                });
#pragma warning restore 612, 618
        }
    }
}
