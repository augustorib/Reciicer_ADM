using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class FieldsToEstoque : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e3f0097-b068-46e0-bfaf-a62f5047ba76", "0dd43541-c91d-4d2e-94e4-5f402eba2c80" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8e7f848e-9a37-4e83-8f5c-43dbce8ff8b1", "2465b77e-436c-4914-aa73-f87ee4bf90ec" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e3f0097-b068-46e0-bfaf-a62f5047ba76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e7f848e-9a37-4e83-8f5c-43dbce8ff8b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0dd43541-c91d-4d2e-94e4-5f402eba2c80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2465b77e-436c-4914-aa73-f87ee4bf90ec");

            migrationBuilder.AddColumn<int>(
                name: "Capacidade",
                table: "Estoque",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PesoArmazenado",
                table: "Estoque",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuantidadeArmazenada",
                table: "Estoque",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                    { "02f34b97-229a-4764-ba00-2298903959c5", 0, "82e5346b-fcf8-4100-bccd-60f8da412209", "operador@gmail.com", false, false, null, "OPERADOR@GMAIL.COM", "OPERADOR", "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", null, false, 2, "9982ee91-1e94-44e8-98d1-c6d34f3c93cf", false, "operador" },
                    { "8868b1f4-812f-4bbd-a438-1b25f7241f78", 0, "56006c13-7319-448b-8bc1-075f25634e32", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", null, false, 1, "4c55f438-7920-4646-92c3-b39357247a18", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 25, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 25, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 25, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 25, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 26, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2025, 3, 17, 3, 10, 24, 26, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Estoque",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacidade", "PesoArmazenado", "QuantidadeArmazenada" },
                values: new object[] { 10, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Estoque",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacidade", "PesoArmazenado", "QuantidadeArmazenada" },
                values: new object[] { 5, 0, 0 });

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
                name: "Capacidade",
                table: "Estoque");

            migrationBuilder.DropColumn(
                name: "PesoArmazenado",
                table: "Estoque");

            migrationBuilder.DropColumn(
                name: "QuantidadeArmazenada",
                table: "Estoque");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5e3f0097-b068-46e0-bfaf-a62f5047ba76", null, "Operador", "OPERADOR" },
                    { "8e7f848e-9a37-4e83-8f5c-43dbce8ff8b1", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PontoColetaId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0dd43541-c91d-4d2e-94e4-5f402eba2c80", 0, "ab7ad525-ccc4-4bc6-9ce5-e2e595e62425", "operador@gmail.com", false, false, null, "OPERADOR@GMAIL.COM", "OPERADOR", "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", null, false, 2, "4c29d6aa-be4a-466e-a4db-436fb0a9b934", false, "operador" },
                    { "2465b77e-436c-4914-aa73-f87ee4bf90ec", 0, "4e91a90f-852a-4ffe-905f-1dada028b425", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", null, false, 1, "010634b7-4168-49bf-b17e-0b1bcc553aeb", false, "admin" }
                });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 14, 3, 42, 29, 581, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 14, 3, 42, 29, 581, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 14, 3, 42, 29, 581, DateTimeKind.Local).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 14, 3, 42, 29, 581, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2025, 3, 14, 3, 42, 29, 581, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2025, 3, 14, 3, 42, 29, 581, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5e3f0097-b068-46e0-bfaf-a62f5047ba76", "0dd43541-c91d-4d2e-94e4-5f402eba2c80" },
                    { "8e7f848e-9a37-4e83-8f5c-43dbce8ff8b1", "2465b77e-436c-4914-aa73-f87ee4bf90ec" }
                });
        }
    }
}
