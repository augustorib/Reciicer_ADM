using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reciicer.Migrations
{
    /// <inheritdoc />
    public partial class RecolhimentoEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Cooperativa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooperativa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recolhimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataRecolhimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PontoColetaId = table.Column<int>(type: "int", nullable: false),
                    CooperativaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recolhimento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recolhimento_Cooperativa_CooperativaId",
                        column: x => x.CooperativaId,
                        principalTable: "Cooperativa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recolhimento_PontoColeta_PontoColetaId",
                        column: x => x.PontoColetaId,
                        principalTable: "PontoColeta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recolhimento_Material",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecolhimentoId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    QuantidadeTotal = table.Column<int>(type: "int", nullable: false),
                    PesoTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recolhimento_Material", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recolhimento_Material_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recolhimento_Material_Recolhimento_RecolhimentoId",
                        column: x => x.RecolhimentoId,
                        principalTable: "Recolhimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64e2abe3-53d8-4b78-a4a6-b86549566435", null, "Admin", "ADMIN" },
                    { "afa8ed0e-50b0-40f6-9ff3-406923de52fd", null, "Operador", "OPERADOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PontoColetaId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1d26d406-c4ab-4d7e-a64f-fed9a5c303fd", 0, "1cd3ec3b-40a1-49a7-81fd-f1261201a749", "admin@gmail.com", false, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAELOGUtUv5slutFj/g2ySNtpAyK6JnEzlfSGIQVH2hL8onfOArNzzqS3hzh4KBbfBlg==", null, false, 1, "e7c2ff9b-0aa1-40bb-9083-2efc830377ef", false, "admin" },
                    { "9c95b117-3d26-405b-bd53-aafc2f0af781", 0, "a24c045d-2cd5-47fb-b68c-9e41f50426d0", "operador@gmail.com", false, false, null, "OPERADOR@GMAIL.COM", "OPERADOR", "AQAAAAIAAYagAAAAEHQ7mga+DIAlOUen1rubIYWrGtJL/2ELlGuZQrZgvy/1u0aPPJa1UHG0VWqHJa06uA==", null, false, 2, "353deaad-a083-42c4-99f2-2354d1109882", false, "operador" }
                });

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 10, 6, 12, 34, 825, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 10, 6, 12, 34, 825, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 10, 6, 12, 34, 825, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "Cliente",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataCadastro",
                value: new DateTime(2025, 3, 10, 6, 12, 34, 825, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ativo", "DataOperacao" },
                values: new object[] { false, new DateTime(2025, 3, 10, 6, 12, 34, 825, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Coleta",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Ativo", "DataOperacao" },
                values: new object[] { false, new DateTime(2025, 3, 10, 6, 12, 34, 825, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.InsertData(
                table: "Cooperativa",
                columns: new[] { "Id", "CNPJ", "Email", "Nome" },
                values: new object[] { 1, "00.000.000/0000-00", "", "Cooperativa de Reciclagem" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "64e2abe3-53d8-4b78-a4a6-b86549566435", "1d26d406-c4ab-4d7e-a64f-fed9a5c303fd" },
                    { "afa8ed0e-50b0-40f6-9ff3-406923de52fd", "9c95b117-3d26-405b-bd53-aafc2f0af781" }
                });

            migrationBuilder.InsertData(
                table: "Recolhimento",
                columns: new[] { "Id", "CooperativaId", "DataRecolhimento", "PontoColetaId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 21, 4, 23, 6, 153, DateTimeKind.Local), 1 },
                    { 2, 1, new DateTime(2025, 2, 21, 6, 23, 6, 153, DateTimeKind.Local), 2 }
                });

            migrationBuilder.InsertData(
                table: "Recolhimento_Material",
                columns: new[] { "Id", "MaterialId", "PesoTotal", "QuantidadeTotal", "RecolhimentoId" },
                values: new object[,]
                {
                    { 1, 1, 21, 0, 1 },
                    { 2, 2, 0, 10, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recolhimento_CooperativaId",
                table: "Recolhimento",
                column: "CooperativaId");

            migrationBuilder.CreateIndex(
                name: "IX_Recolhimento_PontoColetaId",
                table: "Recolhimento",
                column: "PontoColetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Recolhimento_Material_MaterialId",
                table: "Recolhimento_Material",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Recolhimento_Material_RecolhimentoId",
                table: "Recolhimento_Material",
                column: "RecolhimentoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recolhimento_Material");

            migrationBuilder.DropTable(
                name: "Recolhimento");

            migrationBuilder.DropTable(
                name: "Cooperativa");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "64e2abe3-53d8-4b78-a4a6-b86549566435", "1d26d406-c4ab-4d7e-a64f-fed9a5c303fd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "afa8ed0e-50b0-40f6-9ff3-406923de52fd", "9c95b117-3d26-405b-bd53-aafc2f0af781" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64e2abe3-53d8-4b78-a4a6-b86549566435");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "afa8ed0e-50b0-40f6-9ff3-406923de52fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d26d406-c4ab-4d7e-a64f-fed9a5c303fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9c95b117-3d26-405b-bd53-aafc2f0af781");

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
    }
}
