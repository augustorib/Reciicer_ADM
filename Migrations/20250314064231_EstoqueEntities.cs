using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class EstoqueEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7fcd69ce-df50-4572-ae88-691274d7b32f", "9f5095a1-0d5b-45b5-aa59-5ebb72a57831" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9372600f-97a1-4927-8039-efbcd87049bc", "f43cde04-a3de-4cd6-a515-a1947d7e57f5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fcd69ce-df50-4572-ae88-691274d7b32f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9372600f-97a1-4927-8039-efbcd87049bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f5095a1-0d5b-45b5-aa59-5ebb72a57831");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f43cde04-a3de-4cd6-a515-a1947d7e57f5");

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PontoColetaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estoque_PontoColeta_PontoColetaId",
                        column: x => x.PontoColetaId,
                        principalTable: "PontoColeta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstoqueMaterial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    EstoqueId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoqueMaterial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstoqueMaterial_Estoque_EstoqueId",
                        column: x => x.EstoqueId,
                        principalTable: "Estoque",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstoqueMaterial_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Estoque",
                columns: new[] { "Id", "Codigo", "PontoColetaId", "Tipo" },
                values: new object[,]
                {
                    { 1, "PR001", 1, "Interno" },
                    { 2, "PRN001", 2, "Externo" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5e3f0097-b068-46e0-bfaf-a62f5047ba76", "0dd43541-c91d-4d2e-94e4-5f402eba2c80" },
                    { "8e7f848e-9a37-4e83-8f5c-43dbce8ff8b1", "2465b77e-436c-4914-aa73-f87ee4bf90ec" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estoque_PontoColetaId",
                table: "Estoque",
                column: "PontoColetaId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueMaterial_EstoqueId",
                table: "EstoqueMaterial",
                column: "EstoqueId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueMaterial_MaterialId",
                table: "EstoqueMaterial",
                column: "MaterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstoqueMaterial");

            migrationBuilder.DropTable(
                name: "Estoque");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7fcd69ce-df50-4572-ae88-691274d7b32f", null, "Admin", "ADMIN" },
                    { "9372600f-97a1-4927-8039-efbcd87049bc", null, "Operador", "OPERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PontoColetaId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9f5095a1-0d5b-45b5-aa59-5ebb72a57831", 0, "d562986c-a62e-4d9e-9932-9d72f78faebe", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", null, false, 1, "1e76bdf5-961e-4db1-9776-afbda2a0c47f", false, "admin" },
                    { "f43cde04-a3de-4cd6-a515-a1947d7e57f5", 0, "ab824a71-0e6a-4321-a05d-6f6667d2c0cd", "operador@gmail.com", false, false, null, "OPERADOR@GMAIL.COM", "OPERADOR", "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", null, false, 2, "a7835725-1a50-4e85-8b66-69e41053c625", false, "operador" }
                });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 12, 14, 21, 8, 397, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 12, 14, 21, 8, 397, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 12, 14, 21, 8, 397, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 12, 14, 21, 8, 397, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataOperacao",
                value: new DateTime(2025, 3, 12, 14, 21, 8, 397, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataOperacao",
                value: new DateTime(2025, 3, 12, 14, 21, 8, 397, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7fcd69ce-df50-4572-ae88-691274d7b32f", "9f5095a1-0d5b-45b5-aa59-5ebb72a57831" },
                    { "9372600f-97a1-4927-8039-efbcd87049bc", "f43cde04-a3de-4cd6-a515-a1947d7e57f5" }
                });
        }
    }
}
