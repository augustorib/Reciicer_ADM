using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class IdentityUserRoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19615d2e-336b-47af-9095-01c057678a32", null, "Admin", "ADMIN" },
                    { "459d7219-fb06-4151-9691-bea34d239ad7", null, "Operador", "OPERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7c946a5d-6bed-4ff5-ae66-5ba4991a7260", 0, "74f4d6ff-0fcc-4bc7-8459-08f69ec42e93", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", null, false, "9e2899a5-8505-424c-8242-fbefbff34ac1", false, "admin" },
                    { "9d99c30c-86d3-49af-9a63-d3abae6642b3", 0, "a2355ee1-4d4f-4072-9764-008c646a7f3f", "operador@gmail.com", false, false, null, "OPERADOR@GMAIL.COM", "OPERADOR", "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", null, false, "5f77f74b-dad0-40c1-9fa4-d5e510bafc0a", false, "operador" }
                });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 21, 4, 23, 6, 153, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 21, 4, 23, 6, 153, DateTimeKind.Local).AddTicks(9865));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "19615d2e-336b-47af-9095-01c057678a32", "7c946a5d-6bed-4ff5-ae66-5ba4991a7260" },
                    { "459d7219-fb06-4151-9691-bea34d239ad7", "9d99c30c-86d3-49af-9a63-d3abae6642b3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "19615d2e-336b-47af-9095-01c057678a32", "7c946a5d-6bed-4ff5-ae66-5ba4991a7260" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "459d7219-fb06-4151-9691-bea34d239ad7", "9d99c30c-86d3-49af-9a63-d3abae6642b3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19615d2e-336b-47af-9095-01c057678a32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "459d7219-fb06-4151-9691-bea34d239ad7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c946a5d-6bed-4ff5-ae66-5ba4991a7260");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d99c30c-86d3-49af-9a63-d3abae6642b3");

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 18, 3, 23, 8, 981, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 18, 3, 23, 8, 981, DateTimeKind.Local).AddTicks(5205));
        }
    }
}
