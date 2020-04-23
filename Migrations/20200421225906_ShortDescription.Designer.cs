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
    [Migration("20200421225906_ShortDescription")]
    partial class ShortDescription
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
                            Description = "Keep Cool with Mario",
                            GameSystem = "Only for Nintendo GameCube",
                            ImageThumbnailUrl = "\\Images\\MarioSunshine.png",
                            ImageUrl = "\\Images\\SunshineMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Super Mario Sunshine",
                            Price = 50.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 2,
                            CategoryId = 2,
                            Description = "Save Hyrule",
                            GameSystem = "Only Nintendo 64",
                            ImageThumbnailUrl = "\\Images\\LegendofZelda.png",
                            ImageUrl = "\\Images\\OcarinaThumbnail.png",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "The Legend of Zelda, Ocarina of Time",
                            Price = 40.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 3,
                            CategoryId = 3,
                            Description = "get Bananas",
                            GameSystem = "Only for Nintendo Switch",
                            ImageThumbnailUrl = "\\Images\\DonkeyTropical.jpg",
                            ImageUrl = "\\Images\\DKTropicalThumbnail.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Donkey Kong Country: Tropical Freeze",
                            Price = 40.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 4,
                            CategoryId = 4,
                            Description = "The imaginative world of Nintendo is brought to life by the staggering processing power of Nintendo GameCube in Super Smash Bros. Melee - the most furious, frenzied, frantic fighter of all-time! Choose from 14 of your all-time favorite Nintendo characters and fight using signature moves and weapons. Battle in arenas pulled right from the lush worlds of the Nintendo Universe.",
                            GameSystem = "Only for Nintendo GameCube",
                            ImageThumbnailUrl = "\\Images\\SmashMeleeMain.jpg",
                            ImageUrl = "\\Images\\SmashMeleeThumb.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Super Smash Bros. Melee",
                            Price = 100.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 5,
                            CategoryId = 1,
                            Description = "On a bright, sunny day in the Mushroom Kingdom, Mario goes to visit the princess but finds her castle eerily empty. Leaping through pictures hanging from the walls, he enters 15 magical worlds in a quest to collect the 120 Power Stars pilfered by evil Bowser and save the day. This is the first platformer in the Super Mario series to feature three-dimensional gameplay.",
                            GameSystem = "Only for Nintendo 64",
                            ImageThumbnailUrl = "\\Images\\SuperMario64Thumb.jfif",
                            ImageUrl = "\\Images\\SuperMario64Main.png",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Super Mario 64",
                            Price = 100.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 6,
                            CategoryId = 2,
                            Description = "Save Hyrule",
                            GameSystem = "Only Nintendo Switch",
                            ImageThumbnailUrl = "\\Images\\LinksAwakeningThumb.jfif",
                            ImageUrl = "\\Images\\LinksAwakening.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "The Legend of Zelda: Link's Awakening",
                            Price = 40.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 7,
                            CategoryId = 3,
                            Description = "get Bananas",
                            GameSystem = "Only for Super Nintendo",
                            ImageThumbnailUrl = "\\Images\\DonkeyCountry.jpg",
                            ImageUrl = "\\Images\\DonkeyCountryMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Donkey Kong Country",
                            Price = 40.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 8,
                            CategoryId = 3,
                            Description = "get Bananas",
                            GameSystem = "Only for Super Nintendo",
                            ImageThumbnailUrl = "\\Images\\DKKongoBeat.jpg",
                            ImageUrl = "\\Images\\DKKongoBeatMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Donkey Kong Jungle Beat",
                            Price = 40.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 9,
                            CategoryId = 3,
                            Description = "OG Bananas",
                            GameSystem = "Classic Arcade Game",
                            ImageThumbnailUrl = "\\Images\\DKMain.jpg",
                            ImageUrl = "\\Images\\DKOGMainn.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Donkey Kong",
                            Price = 40.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 10,
                            CategoryId = 1,
                            Description = "Keep Cool with Mario",
                            GameSystem = "Nintendo Entertainment System",
                            ImageThumbnailUrl = "\\Images\\MarioBrosThumb.jpg",
                            ImageUrl = "\\Images\\MarioBros3Main.png",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Super Mario Bros. 3",
                            Price = 50.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 11,
                            CategoryId = 1,
                            Description = "Paper Mario",
                            GameSystem = "Only for Nintendo GameCube",
                            ImageThumbnailUrl = "\\Images\\PaperMarioThumb.jpg",
                            ImageUrl = "\\Images\\PaperMarioMain.png",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Paper Mario: The Thousand-Year Door",
                            Price = 50.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 12,
                            CategoryId = 2,
                            Description = "Save Hyrule",
                            GameSystem = "Only Nintendo 64",
                            ImageThumbnailUrl = "\\Images\\WindWakerThumb.jpg",
                            ImageUrl = "\\Images\\WindWakerMain.png",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "The Legend of Zelda: The Wind Waker",
                            Price = 40.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 13,
                            CategoryId = 2,
                            Description = "Save Hyrule",
                            GameSystem = "Nintendo Wii U",
                            ImageThumbnailUrl = "\\Images\\Hyrule-WarriorsThumb.jfif",
                            ImageUrl = "\\Images\\HyruleMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Hyrule Warriors",
                            Price = 40.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 14,
                            CategoryId = 4,
                            Description = "The imaginative world of Nintendo is brought to life by the staggering processing ",
                            GameSystem = "Only for Nintendo Switch",
                            ImageThumbnailUrl = "\\Images\\MarioKartThumb.jpg",
                            ImageUrl = "\\Images\\MarioMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Mario Kart 8 Deluxe",
                            Price = 100.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 15,
                            CategoryId = 4,
                            Description = "The imaginative world of Nintendo is brought to life by the staggering processing ",
                            GameSystem = "Only for Nintendo Switch",
                            ImageThumbnailUrl = "\\Images\\MatioTennisThumb.jpeg",
                            ImageUrl = "\\Images\\MarioTennisMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Mario Tennis Aces",
                            Price = 100.00m,
                            ShortDescription = "it me"
                        },
                        new
                        {
                            GameId = 16,
                            CategoryId = 4,
                            Description = "The imaginative world of Nintendo is brought to life by the staggering processing ",
                            GameSystem = "Only for Nintendo 64",
                            ImageThumbnailUrl = "\\Images\\DiddyRacingThumb.jpg",
                            ImageUrl = "\\Images\\DiddyRacingMain.jpg",
                            IsInStock = true,
                            IsonSale = true,
                            Name = "Diddy Kong Racing",
                            Price = 100.00m,
                            ShortDescription = "it me"
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
