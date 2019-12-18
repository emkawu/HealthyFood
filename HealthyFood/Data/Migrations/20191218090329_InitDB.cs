using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyFood.Data.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "688ae5b6-5cfc-4508-a2b9-26c584fd0cd8", "d3c8d255-46d3-440f-a911-f95945bd66b7", "Admin", "ADMIN" },
                    { "c9f1cf09-78d4-4bf1-b3e0-5c77d40d5d63", "74b3c558-1c00-428f-9c5e-c361a7a08bd9", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d0cd47b1-bcc1-41a8-bf05-9f03c7a0ecb9", 0, "02757f18-3d13-4769-b4f3-28896ab13e42", "admin@healthyfood.com", true, false, null, "ADMIN@HEALTHYFOOD.COM", "ADMIN", "AQAAAAEAACcQAAAAEEvHOE/OAeL9ndK5FlMc3byrvWh2LoZya19WJhR7qgv4mS2+wqTDJSvcRChLUURDsg==", "123456789", false, "a7224ac8-b5e1-4bd0-b4cf-688f53bac812", false, "admin@healthyfood.com" },
                    { "ed4ae3c5-36c5-4109-90e2-7d7d311803cc", 0, "b318b676-e31d-4aa7-8a23-5551adfcbba0", "user@healthyfood.com", true, false, null, "USER@HEALTHYFOOD.COM", "USER", "AQAAAAEAACcQAAAAEK/Jh6o9CRIlUqB1yR7ZePFVzrvTfJ7DEG0+AnyqXpV2J6M3PwUDkWdgaj0P+wJM+g==", "123456789", false, "8d182b2b-7ab0-44d3-8139-d99c94d2a1ba", false, "user@healthyfood.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "d0cd47b1-bcc1-41a8-bf05-9f03c7a0ecb9", "688ae5b6-5cfc-4508-a2b9-26c584fd0cd8" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "ed4ae3c5-36c5-4109-90e2-7d7d311803cc", "c9f1cf09-78d4-4bf1-b3e0-5c77d40d5d63" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d0cd47b1-bcc1-41a8-bf05-9f03c7a0ecb9", "688ae5b6-5cfc-4508-a2b9-26c584fd0cd8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ed4ae3c5-36c5-4109-90e2-7d7d311803cc", "c9f1cf09-78d4-4bf1-b3e0-5c77d40d5d63" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "688ae5b6-5cfc-4508-a2b9-26c584fd0cd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9f1cf09-78d4-4bf1-b3e0-5c77d40d5d63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0cd47b1-bcc1-41a8-bf05-9f03c7a0ecb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed4ae3c5-36c5-4109-90e2-7d7d311803cc");

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
        }
    }
}
