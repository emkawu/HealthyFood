using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyFood.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Cat_CatId = table.Column<Guid>(nullable: false),
                    Cat_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Cat_Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Cat_CatId);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Day_DayId = table.Column<Guid>(nullable: false),
                    Day_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Day_Desc = table.Column<string>(nullable: true),
                    Day_ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Day_DayId);
                    table.ForeignKey(
                        name: "FK_Days_AspNetUsers_Day_ApplicationUserId",
                        column: x => x.Day_ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Mea_MeaId = table.Column<Guid>(nullable: false),
                    Mea_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Mea_Desc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Mea_MeaId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Ing_IngId = table.Column<Guid>(nullable: false),
                    Ing_Name = table.Column<string>(maxLength: 50, nullable: false),
                    Ing_Description = table.Column<string>(nullable: true),
                    Ing_Protein = table.Column<decimal>(nullable: false),
                    Ing_Carb = table.Column<decimal>(nullable: false),
                    Ing_Fat = table.Column<decimal>(nullable: false),
                    Ing_Calories = table.Column<decimal>(nullable: false),
                    Ing_CatId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Ing_IngId);
                    table.ForeignKey(
                        name: "FK_Ingredients_Categories_Ing_CatId",
                        column: x => x.Ing_CatId,
                        principalTable: "Categories",
                        principalColumn: "Cat_CatId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Link_Day_Meals",
                columns: table => new
                {
                    LDM_LDMId = table.Column<Guid>(nullable: false),
                    LDM_DayId = table.Column<Guid>(nullable: false),
                    LDM_MeaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link_Day_Meals", x => x.LDM_LDMId);
                    table.ForeignKey(
                        name: "FK_Link_Day_Meals_Days_LDM_DayId",
                        column: x => x.LDM_DayId,
                        principalTable: "Days",
                        principalColumn: "Day_DayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Link_Day_Meals_Meals_LDM_MeaId",
                        column: x => x.LDM_MeaId,
                        principalTable: "Meals",
                        principalColumn: "Mea_MeaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Link_Meal_Ingredients",
                columns: table => new
                {
                    LMI_LMIId = table.Column<Guid>(nullable: false),
                    LMI_Portion = table.Column<decimal>(nullable: false),
                    LMI_DayId = table.Column<Guid>(nullable: false),
                    LMI_IngId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Link_Meal_Ingredients", x => x.LMI_LMIId);
                    table.ForeignKey(
                        name: "FK_Link_Meal_Ingredients_Days_LMI_DayId",
                        column: x => x.LMI_DayId,
                        principalTable: "Days",
                        principalColumn: "Day_DayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Link_Meal_Ingredients_Ingredients_LMI_IngId",
                        column: x => x.LMI_IngId,
                        principalTable: "Ingredients",
                        principalColumn: "Ing_IngId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "45caec1c-7220-4204-ae1c-7684cc747a0e", "033fbaf1-ceaf-4ce4-a9a2-0514e50fdc6f", "Admin", "ADMIN" },
                    { "18fd5005-6614-471e-8fc6-604e857a5938", "c4c928fe-dba4-4f4e-81bb-6bc67c796b83", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a61dd225-0993-4eae-ad8e-b645ce617bad", 0, "6d58fcad-4f45-4b20-98bc-3fd263f49ba0", "admin@healthyfood.com", true, false, null, "ADMIN@HEALTHYFOOD.COM", "ADMIN", "AQAAAAEAACcQAAAAEIBifGy/AM9oPKU0MPYtlW9sgVklgXyT8A3dZ3JTg0qUwmTFMohAkkPsCl49+LPH+A==", "123456789", false, "576218a4-a2a6-4fc3-9f51-971e14934aab", false, "admin@healthyfood.com" },
                    { "d00c5de0-8855-4b43-8869-825b775391ac", 0, "ed493db4-8987-4b97-a055-05891ee9a1d1", "user@healthyfood.com", true, false, null, "USER@HEALTHYFOOD.COM", "USER", "AQAAAAEAACcQAAAAEIAW7REvNT62IfTNFW6S8DNL7cPrCp3lKXhUv2/dJuPuxobS9MOFi0t3Qj1hQeuoiw==", "123456789", false, "52224020-37fa-4877-ac0d-4732fa712c9e", false, "user@healthyfood.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Cat_CatId", "Cat_Desc", "Cat_Name" },
                values: new object[,]
                {
                    { new Guid("4879aa16-f9f1-4b51-9124-d00a9d5637ca"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec auctor pretium eros, sed mollis lectus blandit sit amet. Vivamus finibus iaculis ligula vitae sodales. Fusce hendrerit blandit molestie. Morbi quis leo lacus.", "Category 1" },
                    { new Guid("42e6406b-1aec-44f2-9503-7109cd9b11d2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam aliquet, massa quis pellentesque consequat, nunc lectus blandit elit, eget fringilla lorem ante at nulla.", "Category 2" },
                    { new Guid("a872b4af-fe87-4b6a-b9fe-e57ad2c23184"), "Pellentesque velit felis, sagittis lacinia lacinia sit amet, venenatis ut urna. Donec elit mi, ornare non rhoncus in, elementum et mi. Donec eleifend placerat massa, pretium aliquam diam mattis in.", "Category 3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Days_Day_ApplicationUserId",
                table: "Days",
                column: "Day_ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_Ing_CatId",
                table: "Ingredients",
                column: "Ing_CatId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_Day_Meals_LDM_DayId",
                table: "Link_Day_Meals",
                column: "LDM_DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_Day_Meals_LDM_MeaId",
                table: "Link_Day_Meals",
                column: "LDM_MeaId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_Meal_Ingredients_LMI_DayId",
                table: "Link_Meal_Ingredients",
                column: "LMI_DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Link_Meal_Ingredients_LMI_IngId",
                table: "Link_Meal_Ingredients",
                column: "LMI_IngId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Link_Day_Meals");

            migrationBuilder.DropTable(
                name: "Link_Meal_Ingredients");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18fd5005-6614-471e-8fc6-604e857a5938");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45caec1c-7220-4204-ae1c-7684cc747a0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a61dd225-0993-4eae-ad8e-b645ce617bad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d00c5de0-8855-4b43-8869-825b775391ac");
        }
    }
}
