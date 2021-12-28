using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Infrastructure.Migrations
{
    public partial class Deploy : Migration
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
                values: new object[] { "a0e8fee6-2509-42af-a96f-2085d7ce92e5", "23cc095b-496d-451e-bb4e-747552eeccd0", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "50bb70ff-709e-4e5e-affb-741aa0cd52b1", 0, "a82ff939-4df2-47ef-92fc-a0c04a17a479", "dinaiovcheva@gmail.com", true, false, null, "DINAIOVCHEVA@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEBLK27N7ClqZfECWV022YE+MQ8NwSJWsfhdo5SC0c6QU+blbzdTsTMwDBCjfoR/MrA==", null, false, "1643d6a5-2ef4-4563-acac-74df37fe6e0f", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 12, 26, 18, 26, 28, 285, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostDate",
                value: new DateTime(2021, 12, 26, 18, 26, 28, 285, DateTimeKind.Local).AddTicks(4407));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PostDate",
                value: new DateTime(2021, 12, 26, 18, 26, 28, 285, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThreadOpenedDate",
                value: new DateTime(2021, 12, 26, 18, 26, 28, 285, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Threads",
                keyColumn: "Id",
                keyValue: 2,
                column: "ThreadOpenedDate",
                value: new DateTime(2021, 12, 26, 18, 26, 28, 285, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a0e8fee6-2509-42af-a96f-2085d7ce92e5", "50bb70ff-709e-4e5e-affb-741aa0cd52b1" });

            migrationBuilder.UpdateData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApplicationUserId", "RegistrationDate" },
                values: new object[] { "50bb70ff-709e-4e5e-affb-741aa0cd52b1", new DateTime(2021, 12, 26, 18, 26, 28, 281, DateTimeKind.Local).AddTicks(9691) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a0e8fee6-2509-42af-a96f-2085d7ce92e5", "50bb70ff-709e-4e5e-affb-741aa0cd52b1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0e8fee6-2509-42af-a96f-2085d7ce92e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50bb70ff-709e-4e5e-affb-741aa0cd52b1");

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
