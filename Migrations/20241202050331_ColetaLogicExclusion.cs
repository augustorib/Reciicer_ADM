using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class ColetaLogicExclusion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ace79492-4c2c-4796-8b35-43b55a93c8e6", "0761a789-e6e6-4f61-991d-4d73c7145cf2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9dd6959b-db2e-43b8-8a10-495dde0df27d", "9e84b8f9-80ba-4639-ae6f-e2749d338067" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9dd6959b-db2e-43b8-8a10-495dde0df27d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ace79492-4c2c-4796-8b35-43b55a93c8e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0761a789-e6e6-4f61-991d-4d73c7145cf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e84b8f9-80ba-4639-ae6f-e2749d338067");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Coleta",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "298f1256-ec97-4797-966c-d813afa14f70", null, "Admin", "ADMIN" },
                    { "8a62bbbf-8420-459c-94d3-9da153f3803f", null, "Operador", "OPERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PontoColetaId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "02f34b97-229a-4764-ba00-2298903959c5", 0, "55c367b0-d91b-4e42-b337-1155bc64ce73", "operador@gmail.com", false, false, null, "OPERADOR@GMAIL.COM", "OPERADOR", "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", null, false, 2, "67a4e605-693b-4d29-9bfe-084295889a4c", false, "operador" },
                    { "8868b1f4-812f-4bbd-a438-1b25f7241f78", 0, "ddbfd18c-a10a-429d-9524-5b5e5d851135", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", null, false, 1, "c8315ee1-2072-40d3-8750-4ed254c654c8", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2024, 12, 2, 2, 3, 31, 367, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2024, 12, 2, 2, 3, 31, 367, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2024, 12, 2, 2, 3, 31, 367, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2024, 12, 2, 2, 3, 31, 367, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ativo", "DataOperacao" },
                values: new object[] { true, new DateTime(2024, 12, 2, 2, 3, 31, 367, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Ativo", "DataOperacao" },
                values: new object[] { true, new DateTime(2024, 12, 2, 2, 3, 31, 367, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8a62bbbf-8420-459c-94d3-9da153f3803f", "02f34b97-229a-4764-ba00-2298903959c5" },
                    { "298f1256-ec97-4797-966c-d813afa14f70", "8868b1f4-812f-4bbd-a438-1b25f7241f78" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a62bbbf-8420-459c-94d3-9da153f3803f", "02f34b97-229a-4764-ba00-2298903959c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "298f1256-ec97-4797-966c-d813afa14f70", "8868b1f4-812f-4bbd-a438-1b25f7241f78" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "298f1256-ec97-4797-966c-d813afa14f70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a62bbbf-8420-459c-94d3-9da153f3803f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f34b97-229a-4764-ba00-2298903959c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8868b1f4-812f-4bbd-a438-1b25f7241f78");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Coleta");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Cliente");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9dd6959b-db2e-43b8-8a10-495dde0df27d", null, "Admin", "ADMIN" },
                    { "ace79492-4c2c-4796-8b35-43b55a93c8e6", null, "Operador", "OPERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PontoColetaId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0761a789-e6e6-4f61-991d-4d73c7145cf2", 0, "fc9239ab-13e5-4bc7-a847-c8ab538a828d", "operador@gmail.com", false, false, null, "OPERADOR@GMAIL.COM", "OPERADOR", "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", null, false, 2, "60d8654f-b7a1-4152-b505-1940de26c413", false, "operador" },
                    { "9e84b8f9-80ba-4639-ae6f-e2749d338067", 0, "30ae6818-fc4a-4e27-b1bc-898050fa909e", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", null, false, 1, "edb3279d-5e75-4205-be1b-1b5d07242a40", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 29, 18, 10, 26, 776, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2024, 11, 29, 18, 10, 26, 776, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ace79492-4c2c-4796-8b35-43b55a93c8e6", "0761a789-e6e6-4f61-991d-4d73c7145cf2" },
                    { "9dd6959b-db2e-43b8-8a10-495dde0df27d", "9e84b8f9-80ba-4639-ae6f-e2749d338067" }
                });
        }
    }
}
