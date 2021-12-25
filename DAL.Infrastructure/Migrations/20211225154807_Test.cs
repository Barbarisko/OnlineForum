using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Infrastructure.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a85efda-db00-4823-b6b6-40893078d69f", "003b0471-a211-4992-9a7d-5c6dee90e55f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a85efda-db00-4823-b6b6-40893078d69f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "003b0471-a211-4992-9a7d-5c6dee90e55f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c4981154-1928-46e0-b59a-aee4563784f8", "0e1c2500-c409-4914-95d7-55cfa125ebc0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7cb71a15-b7c9-4aaa-9e76-325ecb027a64", 0, "0c4c51a3-2065-4ae1-8ef1-c198c7ec8ed7", "dinaiovcheva@gmail.com", true, false, null, "DINAIOVCHEVA@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEOsgapqeyamfMa/LlYcJ2KVa9jjbtKvcVEZ6M8SsQ4p6hP7IxEsDqQwwHpKqIBl4SQ==", null, false, "23e4ab69-590c-4ceb-bd65-763b8986a59e", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 12, 25, 17, 48, 6, 16, DateTimeKind.Local).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2021, 12, 25, 17, 48, 6, 16, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2021, 12, 25, 17, 48, 6, 16, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThreadOpenedDate",
                value: new DateTime(2021, 12, 25, 17, 48, 6, 16, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2,
                column: "ThreadOpenedDate",
                value: new DateTime(2021, 12, 25, 17, 48, 6, 16, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c4981154-1928-46e0-b59a-aee4563784f8", "7cb71a15-b7c9-4aaa-9e76-325ecb027a64" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "RegistrationDate" },
                values: new object[] { "7cb71a15-b7c9-4aaa-9e76-325ecb027a64", new DateTime(2021, 12, 25, 17, 48, 6, 14, DateTimeKind.Local).AddTicks(5237) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c4981154-1928-46e0-b59a-aee4563784f8", "7cb71a15-b7c9-4aaa-9e76-325ecb027a64" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4981154-1928-46e0-b59a-aee4563784f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cb71a15-b7c9-4aaa-9e76-325ecb027a64");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a85efda-db00-4823-b6b6-40893078d69f", "f81dcd38-fce2-44ca-9b0d-7cc02667b9d2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "003b0471-a211-4992-9a7d-5c6dee90e55f", 0, "73b96e95-53ac-46ae-b089-a3f574b94a06", "dinaiovcheva@gmail.com", true, false, null, "DINAIOVCHEVA@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEIiOToBtn/W1T7lqAYtuNNqiQYO6py3KFD9AZOXSln8EttkK4DlOR+Z+5tH5/wW7UA==", null, false, "4c729f12-6ae3-4350-9124-24b42fbeb501", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 5, 12, 19, 32, 1, 218, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2021, 5, 12, 19, 32, 1, 219, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2021, 5, 12, 19, 32, 1, 219, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThreadOpenedDate",
                value: new DateTime(2021, 5, 12, 19, 32, 1, 218, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2,
                column: "ThreadOpenedDate",
                value: new DateTime(2021, 5, 12, 19, 32, 1, 218, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8a85efda-db00-4823-b6b6-40893078d69f", "003b0471-a211-4992-9a7d-5c6dee90e55f" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "RegistrationDate" },
                values: new object[] { "003b0471-a211-4992-9a7d-5c6dee90e55f", new DateTime(2021, 5, 12, 19, 32, 1, 211, DateTimeKind.Local).AddTicks(6155) });
        }
    }
}
