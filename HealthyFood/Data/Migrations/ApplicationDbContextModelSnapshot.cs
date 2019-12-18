﻿// <auto-generated />
using System;
using HealthyFood.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthyFood.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthyFood.Entities.Category", b =>
                {
                    b.Property<Guid>("Cat_CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cat_Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cat_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Cat_CatId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Cat_CatId = new Guid("4879aa16-f9f1-4b51-9124-d00a9d5637ca"),
                            Cat_Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec auctor pretium eros, sed mollis lectus blandit sit amet. Vivamus finibus iaculis ligula vitae sodales. Fusce hendrerit blandit molestie. Morbi quis leo lacus.",
                            Cat_Name = "Category 1"
                        },
                        new
                        {
                            Cat_CatId = new Guid("42e6406b-1aec-44f2-9503-7109cd9b11d2"),
                            Cat_Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam aliquet, massa quis pellentesque consequat, nunc lectus blandit elit, eget fringilla lorem ante at nulla.",
                            Cat_Name = "Category 2"
                        },
                        new
                        {
                            Cat_CatId = new Guid("a872b4af-fe87-4b6a-b9fe-e57ad2c23184"),
                            Cat_Desc = "Pellentesque velit felis, sagittis lacinia lacinia sit amet, venenatis ut urna. Donec elit mi, ornare non rhoncus in, elementum et mi. Donec eleifend placerat massa, pretium aliquam diam mattis in.",
                            Cat_Name = "Category 3"
                        });
                });

            modelBuilder.Entity("HealthyFood.Entities.Day", b =>
                {
                    b.Property<Guid>("Day_DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Day_ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Day_Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Day_DayId");

                    b.HasIndex("Day_ApplicationUserId");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("HealthyFood.Entities.Ingredient", b =>
                {
                    b.Property<Guid>("Ing_IngId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Ing_Calories")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Ing_Carb")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("Ing_CatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ing_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Ing_Fat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Ing_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal>("Ing_Protein")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Ing_IngId");

                    b.HasIndex("Ing_CatId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("HealthyFood.Entities.Link_Day_Meal", b =>
                {
                    b.Property<Guid>("LDM_LDMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LDM_DayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LDM_MeaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LDM_LDMId");

                    b.HasIndex("LDM_DayId");

                    b.HasIndex("LDM_MeaId");

                    b.ToTable("Link_Day_Meals");
                });

            modelBuilder.Entity("HealthyFood.Entities.Link_Meal_Ingredient", b =>
                {
                    b.Property<Guid>("LMI_LMIId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LMI_DayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LMI_IngId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("LMI_Portion")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("LMI_LMIId");

                    b.HasIndex("LMI_DayId");

                    b.HasIndex("LMI_IngId");

                    b.ToTable("Link_Meal_Ingredients");
                });

            modelBuilder.Entity("HealthyFood.Entities.Meal", b =>
                {
                    b.Property<Guid>("Mea_MeaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Mea_Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mea_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Mea_MeaId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("HealthyFood.Models.ApplicationUser", b =>
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

                    b.HasData(
                        new
                        {
                            Id = "d0cd47b1-bcc1-41a8-bf05-9f03c7a0ecb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "02757f18-3d13-4769-b4f3-28896ab13e42",
                            Email = "admin@healthyfood.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@HEALTHYFOOD.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEEvHOE/OAeL9ndK5FlMc3byrvWh2LoZya19WJhR7qgv4mS2+wqTDJSvcRChLUURDsg==",
                            PhoneNumber = "123456789",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a7224ac8-b5e1-4bd0-b4cf-688f53bac812",
                            TwoFactorEnabled = false,
                            UserName = "admin@healthyfood.com"
                        },
                        new
                        {
                            Id = "ed4ae3c5-36c5-4109-90e2-7d7d311803cc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b318b676-e31d-4aa7-8a23-5551adfcbba0",
                            Email = "user@healthyfood.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@HEALTHYFOOD.COM",
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEK/Jh6o9CRIlUqB1yR7ZePFVzrvTfJ7DEG0+AnyqXpV2J6M3PwUDkWdgaj0P+wJM+g==",
                            PhoneNumber = "123456789",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8d182b2b-7ab0-44d3-8139-d99c94d2a1ba",
                            TwoFactorEnabled = false,
                            UserName = "user@healthyfood.com"
                        });
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });

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

                    b.HasData(
                        new
                        {
                            Id = "688ae5b6-5cfc-4508-a2b9-26c584fd0cd8",
                            ConcurrencyStamp = "d3c8d255-46d3-440f-a911-f95945bd66b7",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "c9f1cf09-78d4-4bf1-b3e0-5c77d40d5d63",
                            ConcurrencyStamp = "74b3c558-1c00-428f-9c5e-c361a7a08bd9",
                            Name = "User",
                            NormalizedName = "USER"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "d0cd47b1-bcc1-41a8-bf05-9f03c7a0ecb9",
                            RoleId = "688ae5b6-5cfc-4508-a2b9-26c584fd0cd8"
                        },
                        new
                        {
                            UserId = "ed4ae3c5-36c5-4109-90e2-7d7d311803cc",
                            RoleId = "c9f1cf09-78d4-4bf1-b3e0-5c77d40d5d63"
                        });
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

            modelBuilder.Entity("HealthyFood.Entities.Day", b =>
                {
                    b.HasOne("HealthyFood.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("Day_ApplicationUserId");
                });

            modelBuilder.Entity("HealthyFood.Entities.Ingredient", b =>
                {
                    b.HasOne("HealthyFood.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("Ing_CatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HealthyFood.Entities.Link_Day_Meal", b =>
                {
                    b.HasOne("HealthyFood.Entities.Day", "Day")
                        .WithMany()
                        .HasForeignKey("LDM_DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthyFood.Entities.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("LDM_MeaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HealthyFood.Entities.Link_Meal_Ingredient", b =>
                {
                    b.HasOne("HealthyFood.Entities.Day", "Day")
                        .WithMany()
                        .HasForeignKey("LMI_DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthyFood.Entities.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("LMI_IngId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("HealthyFood.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HealthyFood.Models.ApplicationUser", null)
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

                    b.HasOne("HealthyFood.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HealthyFood.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
